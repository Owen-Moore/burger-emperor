using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

//2020 November 26 Owen Moore
namespace burger_emperor
{
    public partial class Form1 : Form
    {// Declaring variables

        double burger = 1.25;
        double fry = 1.09;
        double drink = 0.99;
        double taxrate = 0.13;
        double burgernum;
        double frynum;
        double drinknum;
        double tendered;
        double change;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        { try
            {

                //Making calculating totals button print the total, tax and subtotal

                burgernum = Convert.ToDouble(burgerBox.Text);
                frynum = Convert.ToDouble(fryBox.Text);
                drinknum = Convert.ToDouble(drinkBox.Text);


                double total = (burger * burgernum) + (fry * frynum) + (drink * drinknum);
                double tax = taxrate * total;
                double fulltotal = tax + total;

                taxLabel.Text = $"{tax.ToString("$0.00")}";
                subLabel.Text = $"{total.ToString("$0.00")}";
                fulltotalLabel.Text = $"{fulltotal.ToString("$0.00")}";

            }
            catch { fulltotalLabel.Text = $"must use a number"; }
            
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Making the calculate change button show change

                burgernum = Convert.ToDouble(burgerBox.Text);
                frynum = Convert.ToDouble(fryBox.Text);
                drinknum = Convert.ToDouble(drinkBox.Text);


                double total = (burger * burgernum) + (fry * frynum) + (drink * drinknum);
                double tax = taxrate * total;
                double fulltotal = tax + total;

                tendered = Convert.ToDouble(tenderedBox.Text);
                change = tendered - fulltotal;
                changenumber.Text = $"{change.ToString("$0.00")}";
            }
            catch
            {
                changenumber.Text = $"must use a number";
            }
        }

        private void RecieptButton_Click(object sender, EventArgs e)
        {
            
            // Making print reciept button print the reciept
            double total = (burger * burgernum) + (fry * frynum) + (drink * drinknum);
            double tax = taxrate * total;
            double fulltotal = tax + total;

            SoundPlayer player = new SoundPlayer(Properties.Resources.printer);
            player.Play();

            RecieptLabel.Text = $"BURGER EMPEROR \n\nOrder number 31 \nNovember 26 2020";
            Refresh(); Thread.Sleep(500);
            RecieptLabel.Text += $"\n\n Burgers# {burgernum}     {burger}";
            Refresh(); Thread.Sleep(500);
            RecieptLabel.Text += $"\n Fries# {frynum}     {fry}";
            Refresh(); Thread.Sleep(500);
            RecieptLabel.Text += $"\n Drinks# {drinknum}    {drink}";
            Refresh(); Thread.Sleep(500);
            RecieptLabel.Text += $"\n\n\n Subtotal {total.ToString("$0.00")}";
            Refresh(); Thread.Sleep(500);
            RecieptLabel.Text += $"\n Tax {tax.ToString("$0.00")}";
            Refresh(); Thread.Sleep(500);
            RecieptLabel.Text += $"\n Total {fulltotal.ToString("$0.00")}";
            Refresh(); Thread.Sleep(500);
            RecieptLabel.Text += $"\n\n Tendered {tendered.ToString("$0.00")}";
            Refresh(); Thread.Sleep(500);
            RecieptLabel.Text += $"\n Change {change.ToString("$0.00")}";
            Refresh(); Thread.Sleep(500);
            RecieptLabel.Text += $"\n\n Have a nice day";




        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            RecieptLabel.Text = $"";
            changenumber.Text = $"";
            taxLabel.Text = $"";
            subLabel.Text = $"";
            fulltotalLabel.Text = $"";
            burgerBox.Text = $"";
            fryBox.Text = $"";
            drinkBox.Text = $"";
            tenderedBox.Text = $"";
        }
    } 
}


