using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    [Editor(typeof(AngleEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public class DropDownListProperty
    {
        private List<string> _values = new List<string>();

        public DropDownListProperty()
        {
            _values.Add("Czerwony");
            _values.Add("Zielony");
            _values.Add("Niebieski");
            SelectedItem = "Zielony";
        }

        public DropDownListProperty(List<String> values)
        {
            if (values.Count > 0)
                SelectedItem = values[0];
            else
                SelectedItem = "None";

            Values = values;
        }

        public List<string> Values
        {
            get
            {
                if (_values == null)
                    _values = new List<String>();

                return _values;
            }
            set
            {
                if (value != null)
                    _values = value;
            }
        }

        [Browsable(false)]
        public string SelectedItem { get; set; }

        /// <summary>
        /// The value that we return here will be shown in the property grid.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return SelectedItem;
        }
    }
}
