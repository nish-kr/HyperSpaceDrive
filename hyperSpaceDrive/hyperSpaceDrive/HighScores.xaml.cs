﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace hyperSpaceDrive
{
    public partial class HighScores : PhoneApplicationPage
    {
        public HighScores()
        {
            InitializeComponent();
            tx1.Text = Level.hl1.ToString();
        }
    }
}