using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyToolkits.Resources.Toolkit.Wpf
{
    public class ButtonEx : Button
    {
        static ButtonEx()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonEx), new FrameworkPropertyMetadata(typeof(ButtonEx)));
        }

        /// <summary>
        /// 定义属性,ButtonType
        /// </summary>
        public ButtonType ButtonType
        {
            get { return (ButtonType)GetValue(ButtonTypeProperty); }
            set { SetValue(ButtonTypeProperty, value); }
        }

        /// <summary>
        /// 注册依赖属性,名称是ButtonType;
        /// 类型是ButtonType;
        /// 所有者是ButtonEx;
        /// 默认值是ButtonType.Normal
        /// </summary>
        public static readonly DependencyProperty ButtonTypeProperty =
         DependencyProperty.Register("ButtonType", typeof(ButtonType), typeof(ButtonEx), new PropertyMetadata(ButtonType.Normal));

        /// <summary>
        /// 定义属性 Icon
        /// </summary>
        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        /// <summary>
        /// 注册依赖属性,名称是Icon;
        /// 类型是ImageSource;
        /// 所有者是ButtonEx;
        /// 默认值是null
        /// </summary>
        public static readonly DependencyProperty IconProperty =
         DependencyProperty.Register("Icon", typeof(ImageSource), typeof(ButtonEx), new PropertyMetadata(null));

        /// <summary>
        /// 圆角
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        /// <summary>
        /// 圆角
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty =
         DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ButtonEx), new PropertyMetadata(new CornerRadius(0)));

        /// <summary>
        /// 鼠标滑过字体颜色
        /// </summary>
        public Brush MouseOverForeground
        {
            get { return (Brush)GetValue(MouseOverForegroundProperty); }
            set { SetValue(MouseOverForegroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverForegroundProperty =
         DependencyProperty.Register("MouseOverForeground", typeof(Brush), typeof(ButtonEx), new PropertyMetadata());

        /// <summary>
        /// 鼠标按下字体颜色
        /// </summary>
        public Brush MousePressedForeground
        {
            get { return (Brush)GetValue(MousePressedForegroundProperty); }
            set { SetValue(MousePressedForegroundProperty, value); }
        }

        public static readonly DependencyProperty MousePressedForegroundProperty =
         DependencyProperty.Register("MousePressedForeground", typeof(Brush), typeof(ButtonEx), new PropertyMetadata());

        /// <summary>
        /// 鼠标滑过边框颜色
        /// </summary>
        public Brush MouseOverBorderbrush
        {
            get { return (Brush)GetValue(MouseOverBorderbrushProperty); }
            set { SetValue(MouseOverBorderbrushProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBorderbrushProperty =
         DependencyProperty.Register("MouseOverBorderbrush", typeof(Brush), typeof(ButtonEx), new PropertyMetadata());

        /// <summary>
        /// 鼠标滑过背景颜色
        /// </summary>
        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBackgroundProperty =
         DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(ButtonEx), new PropertyMetadata());

        /// <summary>
        /// 鼠标按下背景颜色
        /// </summary>
        public Brush MousePressedBackground
        {
            get { return (Brush)GetValue(MousePressedBackgroundProperty); }
            set { SetValue(MousePressedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MousePressedBackgroundProperty =
         DependencyProperty.Register("MousePressedBackground", typeof(Brush), typeof(ButtonEx), new PropertyMetadata());
    }

    public enum ButtonType
    {
        Normal,
        Icon,
        Text,
        IconText
    }
}
