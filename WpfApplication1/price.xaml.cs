﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// price.xaml 的互動邏輯
    /// </summary>
     public partial class price : UserControl
    {
        public price()
        {
            InitializeComponent();
        }

        public int itemPriceValue
        {
            get
            {
                try
                {
                    return int.Parse(TaskPrice.Text);
                }

                catch
                {
                    MessageBox.Show("請輸入數字");
                    return 0;
                }
            }
            set
            {
                TaskPrice.Text = value.ToString();
            }
        }
    }
    }

