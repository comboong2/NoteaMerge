﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Notea.Converters
{
    public class SidebarCollapsedToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isCollapsed)
                return isCollapsed ? Visibility.Visible : Visibility.Collapsed;

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
