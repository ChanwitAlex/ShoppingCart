namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                //get amount 
                string strCoffeePrice = tbCoffeePrice.Text;
                string strGreenTeaPrice = tbGreenTeaPrice.Text;
                
                
                //get price
                string strCoffeeQuantity = tbCoffeeQuantity.Text;
                string strGreenTeaQuantity = tbGreenTeaQuantity.Text;

                double iCoffeePrice = 0;
                double iGreenTeaPrice= 0;
                double iCoffeeQuantity = 0;
                double iGreenTeaQuantity = 0;
            try
            {
                //covert string to int
                if (chbCoffee.Checked)
                {
                    iCoffeePrice = double.Parse(strCoffeePrice);
                    iCoffeeQuantity = double.Parse(strCoffeeQuantity);
                }
                if (chbGreentea.Checked)
                {
                    iGreenTeaPrice = double.Parse(strGreenTeaPrice);
                    iGreenTeaQuantity = double.Parse(strGreenTeaQuantity);
                }
            }
            catch (Exception ex)
            {
                 iCoffeePrice = 0;
                 iCoffeeQuantity = 0;
                 iGreenTeaPrice = 0;
                 iGreenTeaQuantity = 0;

            }
        //calculate total
        double iCoffee = iCoffeePrice * iCoffeeQuantity;
        double iGreenTea =iGreenTeaPrice * iGreenTeaQuantity;
        double iTotal = iCoffee + iGreenTea;
        //display total
        tbTotal.Text = iTotal.ToString();

        }
    }
    }

