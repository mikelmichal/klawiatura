using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace klawiatura
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
    
        //TextBox BehaveTextbox;
        static bool capsLockwlaczony = false;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "1";
            else
                _table.Text += "!";
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "2";
            else
                _table.Text += "@";
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "3";
            else
                _table.Text += "#";
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "4";
            else
                _table.Text += "$";
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "5";
            else
                _table.Text += "%";
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "6";
            else
                _table.Text += "^";
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "7";
            else
                _table.Text += "&";
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "8";
            else
                _table.Text += "*";
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "9";
            else
                _table.Text += "(";
        }

        private void _0_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "0";
            else
                _table.Text += ")";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "-";
            else
                _table.Text += "_";
        }

        private void suma_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "=";
            else
                _table.Text += "+";
        }

        private void tyld_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "`";
            else
                _table.Text += "~";
        }

        private void _a_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "a";
            else
                _table.Text += "A";
        }

        private void _q_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "q";
            else
                _table.Text += "Q";
        }

        private void _w_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "w";
            else
                _table.Text += "W";
        }

        private void _e_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "e";
            else
                _table.Text += "E";
        }

        private void _r_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "r";
            else
                _table.Text += "R";
        }

        private void _t_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "t";
            else
                _table.Text += "T";
        }

        private void _y_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "y";
            else
                _table.Text += "Y";
        }

        private void _u_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "u";
            else
                _table.Text += "U";
        }

        private void _i_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "i";
            else
                _table.Text += "I";
        }

        private void _o_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "o";
            else
                _table.Text += "O";
        }

        private void _p_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "p";
            else
                _table.Text += "P";
        }

        private void _s_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "s";
            else
                _table.Text += "S";
        }

        private void _d_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "d";
            else
                _table.Text += "D";
        }

        private void _f_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "f";
            else
                _table.Text += "F";
        }

        private void _g_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "g";
            else
                _table.Text += "G";
        }

        private void _h_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "h";
            else
                _table.Text += "H";
        }

        private void _j_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "j";
            else
                _table.Text += "J";
        }

        private void _k_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "k";
            else
                _table.Text += "K";
        }

        private void _l_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "l";
            else
                _table.Text += "L";
        }

        private void _z_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "z";
            else
                _table.Text += "Z";
        }

        private void _x_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "x";
            else
                _table.Text += "X";
        }

        private void _c_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "c";
            else
                _table.Text += "C";
        }

        private void _v_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "v";
            else
                _table.Text += "V";
        }

        private void _b_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "b";
            else
                _table.Text += "B";
        }

        private void _n_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "n";
            else
                _table.Text += "N";
        }

        private void _m_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "m";
            else
                _table.Text += "M";
        }

        private void leftNa_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "[";
            else
                _table.Text += "{";
        }

        private void righNa_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "]";
            else
                _table.Text += "}";
        }

        private void line_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "\"" ;
            else
                _table.Text += "|";
        }

        private void funk1_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += ";";
            else
                _table.Text += ":";
        }

        private void funk2_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "'";
            else
                _table.Text += "\"";
        }

        private void lstr_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += ",";
            else
                _table.Text += "<";
        }

        private void pstr_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += ".";
            else
                _table.Text += ">";
        }

        private void ques_Click(object sender, RoutedEventArgs e)
        {
            if (!capsLockwlaczony)
                _table.Text += "/";
            else
                _table.Text += "?";
        }

        private void space_Click(object sender, RoutedEventArgs e)
        {
            _table.Text += " ";
        }

        private void crtCaps(object sender, RoutedEventArgs e)
        {
           

        }

        private void capsLock_Click(object sender, RoutedEventArgs e)
        {
          
            if (capsLockwlaczony)
                capsLockwlaczony = false;
            else
                capsLockwlaczony = true;
        }

        private void enter_Click(object sender, RoutedEventArgs e) => _table.Text += "\r\n";

        private void _back_Click(object sender, RoutedEventArgs e)
        {
            string s = _table.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "";
            }

            _table.Text = s;
        }

        
    }
    
}
