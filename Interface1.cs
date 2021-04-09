using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    interface Button
    {
        void sellBtn_Click(object sender, EventArgs e);
        void catBtn_Click(object sender, EventArgs e);
        void prodBtn_Click(object sender, EventArgs e);
    }
}
