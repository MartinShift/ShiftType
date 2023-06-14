using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows;

namespace TypeClient.Models
{
    public static class WatermarkBehavior
    {
        public static readonly DependencyProperty WatermarkTextProperty =
            DependencyProperty.RegisterAttached("WatermarkText", typeof(string), typeof(WatermarkBehavior), new PropertyMetadata(string.Empty, OnWatermarkTextChanged));

        public static string GetWatermarkText(DependencyObject obj)
        {
            return (string)obj.GetValue(WatermarkTextProperty);
        }

        public static void SetWatermarkText(DependencyObject obj, string value)
        {
            obj.SetValue(WatermarkTextProperty, value);
        }

        private static void OnWatermarkTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textBox)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    AddWatermark(textBox);
                }
                else
                {
                    RemoveWatermark(textBox);
                }
            }
        }

        private static void AddWatermark(TextBox textBox)
        {
            var adornerLayer = AdornerLayer.GetAdornerLayer(textBox);
            if (adornerLayer != null)
            {
                var watermarkAdorner = new WatermarkAdorner(textBox, GetWatermarkText(textBox));
                adornerLayer.Add(watermarkAdorner);
            }
        }

        private static void RemoveWatermark(TextBox textBox)
        {
            var adornerLayer = AdornerLayer.GetAdornerLayer(textBox);
            if (adornerLayer != null)
            {
                var adorners = adornerLayer.GetAdorners(textBox);
                if (adorners != null)
                {
                    foreach (var adorner in adorners)
                    {
                        if (adorner is WatermarkAdorner watermarkAdorner)
                        {
                            adornerLayer.Remove(watermarkAdorner);
                        }
                    }
                }
            }
        }
    }
}
