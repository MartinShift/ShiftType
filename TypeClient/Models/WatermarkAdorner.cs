using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows;

namespace TypeClient.Models
{
    public class WatermarkAdorner : Adorner
    {
        private readonly TextBlock watermarkTextBlock;

        public WatermarkAdorner(UIElement adornedElement, string watermarkText)
            : base(adornedElement)
        {
            watermarkTextBlock = new TextBlock
            {
                Text = watermarkText,
                Opacity = 0.5,
                Margin = new Thickness(Control.Margin.Left + Control.Padding.Left, Control.Margin.Top + Control.Padding.Top, 0, 0),
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Left,
                Foreground = Brushes.Gray,
                IsHitTestVisible = false
            };

            AddVisualChild(watermarkTextBlock);

            var textBox = adornedElement as TextBox;
            if (textBox != null)
            {
                textBox.Loaded += TextBox_Loaded;
                textBox.TextChanged += TextBox_TextChanged;
            }
        }

        protected override int VisualChildrenCount => 1;

        private Control Control => AdornedElement as Control;

        protected override Visual GetVisualChild(int index)
        {
            return watermarkTextBlock;
        }

        protected override Size MeasureOverride(Size constraint)
        {
            watermarkTextBlock.Measure(Control.RenderSize);
            return Control.RenderSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            watermarkTextBlock.Arrange(new Rect(finalSize));
            return finalSize;
        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            AddWatermark();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox)?.Text))
            {
                AddWatermark();
            }
            else
            {
                RemoveWatermark();
            }
        }

        private void AddWatermark()
        {
            var adornerLayer = AdornerLayer.GetAdornerLayer(Control);
            if (adornerLayer != null)
            {
                adornerLayer.Add(this);
            }
        }

        private void RemoveWatermark()
        {
            var adornerLayer = AdornerLayer.GetAdornerLayer(Control);
            if (adornerLayer != null)
            {
                adornerLayer.Remove(this);
            }
        }
    }
}
