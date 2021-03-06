﻿/*
 * 
This file is part of the ChapterMerger project
Copyright (C) 2015 Mon C.A.S.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; either version 2 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License along
with this program; if not, write to the Free Software Foundation, Inc.,
51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Deployment.Application;

namespace ChapterMerger
{
  public partial class About : Form
  {

    /// <summary>
    /// Get current product version.
    /// </summary>
    public string CurrentVersion
    {
      get
      {

        return ApplicationDeployment.IsNetworkDeployed
               ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
               //: Assembly.GetExecutingAssembly().GetName().Version.ToString();
               : typeof(About).Assembly.GetName().Version.ToString();
        
      }
    }

    public About()
    {
      InitializeComponent();
    }

    private void About_Load(object sender, EventArgs e)
    {
      this.versionLabel.Text = "Version " + CurrentVersion;
    }
  }
}
