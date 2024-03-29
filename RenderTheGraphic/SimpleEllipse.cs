﻿using System;
using System.Windows;
using System.Windows.Media;

namespace Petzold.RenderTheGraphic
{
    class SimpleEllipse : FrameworkElement
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawEllipse(Brushes.Blue, new Pen(Brushes.Red, 24), new Point(RenderSize.Width / 2, RenderSize.Height / 2), RenderSize.Width / 2, RenderSize.Height / 2 );
        }
    }
}