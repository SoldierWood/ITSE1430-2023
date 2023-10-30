﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChrisSoldierWood.AdventureGame.WinHost
{
    public partial class NewCharForm : Form
    {
        public NewCharForm ()
        {
            InitializeComponent();
        }


        private void OnValidateName ( object sender, CancelEventArgs e )
        {
            if (String.IsNullOrEmpty(_txtCharName.Text))
            {
                // Invalid
                _error.SetError(_txtCharName, "Title is required");
                e.Cancel = true;
            } else
                _error.SetError(_txtCharName, "");

        }

        private void OnValidateProfession ( object sender, CancelEventArgs e )
        {
            if (String.IsNullOrEmpty(_cbProfession.Text))
            {
                //Invalid
                _error.SetError(_cbProfession, "Profession is required");
                e.Cancel = true;
            } else
                _error.SetError(_cbProfession, "");
        }

        private void OnValidateRace ( object sender, CancelEventArgs e )
        {
            if (String.IsNullOrEmpty(_cbRace.Text))
            {
                //Invalid
                _error.SetError(_cbRace, "Profession is required");
                e.Cancel = true;
            } else
                _error.SetError(_cbRace, "");
        }

        private void OnValidateStrength ( object sender, CancelEventArgs e )
        {
            //var value = GetInt32(_txtStrength, 50);
        }

        //private int GetInt32( Control control, iterator defaultValue )
        //{

        //}
    }


}
