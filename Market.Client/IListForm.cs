﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Client
{
    public interface IListForm
    {
        void Reload();

        void Delete();

        Form GetAddForm();

        Form GetEditForm();
    }
}
