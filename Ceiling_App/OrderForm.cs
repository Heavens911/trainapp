using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Ceiling_App.Model;

namespace Ceiling_App
{
    public partial class OrderForm : Form
    {
        private Order order;
        public bool SaveOrder;

        private readonly Control[] validatedControls;

        public OrderForm()
        {
            InitializeComponent();
            validatedControls = new Control[] { PField, SField, SpotField, LustraField, PipeField, UglField };
        }

        public void SetOrder(Order order)
        {
            this.order = order;
            OrderNameField.Text = order.OrderName.ToString();
            PField.Text = order.P.ToString();
            SField.Text = order.S.ToString();
            SpotField.Text = order.Spotlight.ToString();
            LustraField.Text = order.Lustra.ToString();
            PipeField.Text = order.Pipe.ToString();
            UglField.Text = order.Ugl.ToString();
            Price1Field.Text = order.ClientPrice.ToString();
            Price2Field.Text = order.MaterialCost.ToString();
            Price3Field.Text = order.Profit.ToString();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveOrder = true;
            order.OrderName = OrderNameField.Text;
            order.P = ParseToDouble(PField.Text);
            order.S = ParseToDouble(SField.Text);
            order.Spotlight = ParseToInt(SpotField.Text);
            order.Lustra = ParseToInt(LustraField.Text);
            order.Pipe = ParseToInt(PipeField.Text);
            order.Ugl = ParseToInt(UglField.Text);

            Close();

        }
        private double ParseToDouble(string val)
        {

            if (double.TryParse(val, out double result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
        private int ParseToInt(string val)
        {

            if (int.TryParse(val, out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }


        private void CancellButton_Click(object sender, EventArgs e)
        {
            SaveOrder = false;


            Close();
        }

        private void PField_KeyPress(object sender, KeyPressEventArgs e)
        {




            //char number = e.KeyChar;

            //if (!Char.IsDigit(number))
            //{
            //    e.Handled = true;
            //}

        }

        private void PField_TextChanged(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            if (!double.TryParse(textbox.Text, out var _))
            {
                //ValidationProcess();
            }

        }
        private void IntField_Validated(object sender, EventArgs e)
        {
            Field_Validated(sender, (value) => int.TryParse(value, out var _));
        }

        private void DoubleField_Validated(object sender, EventArgs e)
        {
            Field_Validated(sender, (text) => double.TryParse(text, out var _));
        }

        private void Field_Validated(object sender, Func<string, bool> validateFunc)
        {
            var textbox = (TextBox)sender;
            if (!validateFunc(textbox.Text))
            {
                errorProvider.SetIconAlignment(textbox, ErrorIconAlignment.MiddleRight);
                errorProvider.SetError(textbox, "Исправьте ошибку!");
                textbox.ForeColor = Color.Red;
            }
            else
            {
                textbox.ForeColor = Color.Black;
                errorProvider.SetError(textbox, "");
            }
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            bool hasError = validatedControls.Any(FieldHasError);

            button1.Enabled = !hasError;
        }

        private bool FieldHasError(Control ct)
        {
            return !string.IsNullOrEmpty(errorProvider.GetError(ct));
        }
    }
}
