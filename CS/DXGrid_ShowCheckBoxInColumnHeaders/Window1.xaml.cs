﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;

namespace DXGrid_ShowCheckBoxInColumnHeaders {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.DataSource = new nwindDataSetTableAdapters.ProductsTableAdapter().GetData();
        }

    }
}
