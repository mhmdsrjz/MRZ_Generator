using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckDigit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            line1.Hide();
            line2.Hide();
            line3.Hide();
        }        
        string mrz_line1;
        string mrz_line2;
        string mrz_line3;
        string countryabb_birth;
        string countryabb_issue;
        string birthdate;
        string expiredate;
        string firstname;
        string optional;
        string sex;
        bool fHasSpace = false;
        int checkdigit1;
        int checkdigit2;
        int checkdigit3;
        int checkdigit4;
        int checkdigit5;
        string addition;
        string longline;    
        public static int CheckDigit(string mystr)
        {
            int total = 0;
            int k = mystr.Length;
            string[] str = new string[k];
            for (int i = 0; i < k; i++)
            {
                str[i] = mystr.Substring(i, 1);
            }
            for (int j = 0; j < k; j++)
            {
                switch (str[j])
                {
                    case "<":
                        str[j] = "0";
                        break;
                    case "A":
                        str[j] = "10";
                        break;
                    case "B":
                        str[j] = "11";
                        break;
                    case "C":
                        str[j] = "12";
                        break;
                    case "D":
                        str[j] = "13";
                        break;
                    case "E":
                        str[j] = "14";
                        break;
                    case "F":
                        str[j] = "15";
                        break;
                    case "G":
                        str[j] = "16";
                        break;
                    case "H":
                        str[j] = "17";
                        break;
                    case "I":
                        str[j] = "18";
                        break;
                    case "J":
                        str[j] = "19";
                        break;
                    case "K":
                        str[j] = "20";
                        break;
                    case "L":
                        str[j] = "21";
                        break;
                    case "M":
                        str[j] = "22";
                        break;
                    case "N":
                        str[j] = "23";
                        break;
                    case "O":
                        str[j] = "24";
                        break;
                    case "P":
                        str[j] = "25";
                        break;
                    case "Q":
                        str[j] = "26";
                        break;
                    case "R":
                        str[j] = "27";
                        break;
                    case "S":
                        str[j] = "28";
                        break;
                    case "T":
                        str[j] = "29";
                        break;
                    case "U":
                        str[j] = "30";
                        break;
                    case "V":
                        str[j] = "31";
                        break;
                    case "W":
                        str[j] = "32";
                        break;
                    case "X":
                        str[j] = "33";
                        break;
                    case "Y":
                        str[j] = "34";
                        break;
                    case "Z":
                        str[j] = "35";
                        break;
                }
            }
            for (int m = 1; m <= k; m++)
            {
                if (m % 3 == 1)
                {
                    str[m - 1] = Convert.ToString(Convert.ToInt16(str[m - 1]) * 7);
                }
                else if (m % 3 == 2)
                {
                    str[m - 1] = Convert.ToString(Convert.ToInt16(str[m - 1]) * 3);
                }
                else if (m % 3 == 0)
                {
                    str[m - 1] = Convert.ToString(Convert.ToInt16(str[m - 1]) * 1);
                }
            }
            for (int n = 0; n < k; n++)
            {
                total = total + Convert.ToInt16(str[n]);
            }
            total = (total % 10);
            return total;
        }
        public static string Countabb (string country)
        {
            string abb="";
            switch (country)
            {
                case "Afghanistan":
                    abb = "AFG";
                    break;
                case "Albania":
                    abb = "ALB";
                    break;
                case "Algeria":
                    abb = "DZA";
                    break;
                case "American Samoa":
                    abb = "ASM";
                    break;
                case "Andorra":
                    abb = "AND";
                    break;
                case "Angola":
                    abb = "AGO";
                    break;
                case "Anguilla":
                    abb = "AIA";
                    break;
                case "Antarctica":
                    abb = "ATA";
                    break;
                case "Antigua and Barbuda":
                    abb = "ATG";
                    break;
                case "Argentina":
                    abb = "ARG";
                    break;
                case "Armenia":
                    abb = "ARM";
                    break;
                case "Aruba":
                    abb = "ABW";
                    break;
                case "Australia":
                    abb = "AUS";
                    break;
                case "Austria":
                    abb = "AUT";
                    break;
                case "Azerbaijan":
                    abb = "AZE";
                    break;
                case "Bahamas":
                    abb = "BHS";
                    break;
                case "Bahrain":
                    abb = "BHR";
                    break;
                case "Bangladesh":
                    abb = "BGD";
                    break;
                case "Barbados":
                    abb = "BRB";
                    break;
                case "Belarus":
                    abb = "BLR";
                    break;
                case "Belgium":
                    abb = "BEL";
                    break;
                case "Belize":
                    abb = "BLZ";
                    break;
                case "Benin":
                    abb = "BEN";
                    break;
                case "Bermuda":
                    abb = "BMU";
                    break;
                case "Bhutan":
                    abb = "BTN";
                    break;
                case "Bolivia":
                    abb = "BOL";
                    break;
                case "Bosnia and Herzegovina":
                    abb = "BIH";
                    break;
                case "Botswana":
                    abb = "BWA";
                    break;
                case "Bouvet Island":
                    abb = "BVT";
                    break;
                case "Brazil":
                    abb = "BRA";
                    break;
                case "British Indian Ocean Territory":
                    abb = "IOT";
                    break;
                case "Brunei Darussalam":
                    abb = "BRN";
                    break;
                case "Bulgaria":
                    abb = "BGR";
                    break;
                case "Burkina Faso":
                    abb = "BFA";
                    break;
                case "Burundi":
                    abb = "BDI";
                    break;
                case "Cambodia":
                    abb = "KHM";
                    break;
                case "Cameroon":
                    abb = "CMR";
                    break;
                case "Canada":
                    abb = "CAN";
                    break;
                case "Cape Verde":
                    abb = "CPV";
                    break;
                case "Cayman Islands":
                    abb = "CYM";
                    break;
                case "Central African Republic":
                    abb = "CAF";
                    break;
                case "Chad":
                    abb = "TCD";
                    break;
                case "Chile":
                    abb = "CHL";
                    break;
                case "China":
                    abb = "CHN";
                    break;
                case "Christmas Island":
                    abb = "CXR";
                    break;
                case "Cocos (Keeling) Islands":
                    abb = "CCK";
                    break;
                case "Colombia":
                    abb = "COL";
                    break;
                case "Comoros":
                    abb = "COM";
                    break;
                case "Congo":
                    abb = "COG";
                    break;
                case "Cook Islands":
                    abb = "COK";
                    break;
                case "Costa Rica":
                    abb = "CRI";
                    break;
                case "Côte d'Ivoire":
                    abb = "CIV";
                    break;
                case "Croatia":
                    abb = "HRV";
                    break;
                case "Cuba":
                    abb = "CUB";
                    break;
                case "Cyprus":
                    abb = "CYP";
                    break;
                case "Czech Republic":
                    abb = "CZE";
                    break;
                case "Democratic People's Republic of Korea":
                    abb = "PRK";
                    break;
                case "Democratic Republic of the Congo":
                    abb = "COD";
                    break;
                case "Denmark":
                    abb = "DNK";
                    break;
                case "Djibouti":
                    abb = "DJI";
                    break;
                case "Dominica":
                    abb = "DMA";
                    break;
                case "Dominican Republic":
                    abb = "DOM";
                    break;
                case "East Timor":
                    abb = "TMP";
                    break;
                case "Ecuador":
                    abb = "ECU";
                    break;
                case "Egypt":
                    abb = "EGY";
                    break;
                case "El Salvador":
                    abb = "SLV";
                    break;
                case "Equatorial Guinea":
                    abb = "GNQ";
                    break;
                case "Eritrea":
                    abb = "ERI";
                    break;
                case "Estonia":
                    abb = "EST";
                    break;
                case "Ethiopia":
                    abb = "ETH";
                    break;
                case "Falkland Islands (Malvinas)":
                    abb = "FLK";
                    break;
                case "Faeroe Islands":
                    abb = "FRO";
                    break;
                case "Fiji":
                    abb = "FJI";
                    break;
                case "Finland":
                    abb = "FIN";
                    break;
                case "France":
                    abb = "FRA";
                    break;
                case "France, Metropolitan":
                    abb = "FXX";
                    break;
                case "French Guiana":
                    abb = "GUF";
                    break;
                case "French Polynesia":
                    abb = "PYF";
                    break;
                case "Gabon":
                    abb = "GAB";
                    break;
                case "Gambia":
                    abb = "GMB";
                    break;
                case "Georgia":
                    abb = "GEO";
                    break;
                case "Germany":
                    abb = "D";
                    break;
                case "Ghana":
                    abb = "GHA";
                    break;
                case "Gibraltar":
                    abb = "GIB";
                    break;
                case "Greece":
                    abb = "GRC";
                    break;
                case "Greenland":
                    abb = "GRL";
                    break;
                case "Grenada":
                    abb = "GRD";
                    break;
                case "Guadeloupe":
                    abb = "GLP";
                    break;
                case "Guam":
                    abb = "GUM";
                    break;
                case "Guatemala":
                    abb = "GTM";
                    break;
                case "Guinea":
                    abb = "GIN";
                    break;
                case "Guinea-Bissau":
                    abb = "GNB";
                    break;
                case "Guyana":
                    abb = "GUY";
                    break;
                case "Haiti":
                    abb = "HTI";
                    break;
                case "Heard and McDonald Islands":
                    abb = "HMD";
                    break;
                case "Holy See (Vatican City State)":
                    abb = "VAT";
                    break;
                case "Honduras":
                    abb = "HND";
                    break;
                case "Hong Kong":
                    abb = "HKG";
                    break;
                case "Hungary":
                    abb = "HUN";
                    break;
                case "Iceland":
                    abb = "ISL";
                    break;
                case "India":
                    abb = "IND";
                    break;
                case "Indonesia":
                    abb = "IDN";
                    break;
                case "Iran, Islamic Republic of":
                    abb = "IRN";
                    break;
                case "Iraq":
                    abb = "IRQ";
                    break;
                case "Ireland":
                    abb = "IRL";
                    break;
                case "Israel":
                    abb = "ISR";
                    break;
                case "Italy":
                    abb = "ITA";
                    break;
                case "Jamaica":
                    abb = "JAM";
                    break;
                case "Japan":
                    abb = "JPN";
                    break;
                case "Jordan":
                    abb = "JOR";
                    break;
                case "Kazakhstan":
                    abb = "KAZ";
                    break;
                case "Kenya":
                    abb = "KEN";
                    break;
                case "Kiribati":
                    abb = "KIR";
                    break;
                case "Kuwait":
                    abb = "KWT";
                    break;
                case "Kyrgyzstan":
                    abb = "KGZ";
                    break;
                case "Lao People's Democratic Republic":
                    abb = "LAO";
                    break;
                case "Latvia":
                    abb = "LVA";
                    break;
                case "Lebanon":
                    abb = "LBN";
                    break;
                case "Lesotho":
                    abb = "LSO";
                    break;
                case "Liberia":
                    abb = "LBR";
                    break;
                case "Libyan Arab Jamahiriya":
                    abb = "LBY";
                    break;
                case "Liechtenstein":
                    abb = "LIE";
                    break;
                case "Lithuania":
                    abb = "LTU";
                    break;
                case "Luxembourg":
                    abb = "LUX";
                    break;
                case "Madagascar":
                    abb = "MDG";
                    break;
                case "Malawi":
                    abb = "MWI";
                    break;
                case "Malaysia":
                    abb = "MYS";
                    break;
                case "Maldives":
                    abb = "MDV";
                    break;
                case "Mali":
                    abb = "MLI";
                    break;
                case "Malta":
                    abb = "MLT";
                    break;
                case "Marshall Islands":
                    abb = "MHL";
                    break;
                case "Martinique":
                    abb = "MTQ";
                    break;
                case "Mauritania":
                    abb = "MRT";
                    break;
                case "Mauritius":
                    abb = "MUS";
                    break;
                case "Mayotte":
                    abb = "MYT";
                    break;
                case "Mexico":
                    abb = "MEX";
                    break;
                case "Micronesia, Federated States of":
                    abb = "FSM";
                    break;
                case "Monaco":
                    abb = "MCO";
                    break;
                case "Mongolia":
                    abb = "MNG";
                    break;
                case "Montserrat":
                    abb = "MSR";
                    break;
                case "Morocco":
                    abb = "MAR";
                    break;
                case "Mozambique":
                    abb = "MOZ";
                    break;
                case "Myanmar":
                    abb = "MMR";
                    break;
                case "Namibia":
                    abb = "NAM";
                    break;
                case "Nauru":
                    abb = "NRU";
                    break;
                case "Nepal":
                    abb = "NPL";
                    break;
                case "Netherlands, Kingdom of the":
                    abb = "NLD";
                    break;
                case "Netherlands Antilles":
                    abb = "ANT";
                    break;
                case "Neutral Zone":
                    abb = "NTZ";
                    break;
                case "New Caledonia":
                    abb = "NCL";
                    break;
                case "New Zealand":
                    abb = "NZL";
                    break;
                case "Nicaragua":
                    abb = "NIC";
                    break;
                case "Niger":
                    abb = "NER";
                    break;
                case "Nigeria":
                    abb = "NGA";
                    break;
                case "Niue":
                    abb = "NIU";
                    break;
                case "Norfolk Island":
                    abb = "NFK";
                    break;
                case "Northern Mariana Islands":
                    abb = "MNP";
                    break;
                case "Norway":
                    abb = "NOR";
                    break;
                case "Oman":
                    abb = "OMN";
                    break;
                case "Pakistan":
                    abb = "PAK";
                    break;
                case "Palau":
                    abb = "PLW";
                    break;
                case "Panama":
                    abb = "PAN";
                    break;
                case "Papua New Guinea":
                    abb = "PNG";
                    break;
                case "Paraguay":
                    abb = "PRY";
                    break;
                case "Peru":
                    abb = "PER";
                    break;
                case "Philippines":
                    abb = "PHL";
                    break;
                case "Pitcairn":
                    abb = "PCN";
                    break;
                case "Poland":
                    abb = "POL";
                    break;
                case "Portugal":
                    abb = "PRT";
                    break;
                case "Puerto Rico":
                    abb = "PRI";
                    break;
                case "Qatar":
                    abb = "QAT";
                    break;
                case "Republic of Korea":
                    abb = "KOR";
                    break;
                case "Republic of Moldova":
                    abb = "MDA";
                    break;
                case "Réunion":
                    abb = "REU";
                    break;
                case "Romania":
                    abb = "ROM";
                    break;
                case "Russian Federation":
                    abb = "RUS";
                    break;
                case "Rwanda":
                    abb = "RWA";
                    break;
                case "Saint Helena":
                    abb = "SHN";
                    break;
                case "Saint Kitts and Nevis":
                    abb = "KNA";
                    break;
                case "Saint Lucia":
                    abb = "LCA";
                    break;
                case "Saint Pierre and Miquelon":
                    abb = "SPM";
                    break;
                case "Saint Vincent and the Grenadines":
                    abb = "VCT";
                    break;
                case "Samoa":
                    abb = "WSM";
                    break;
                case "San Marino":
                    abb = "SMR";
                    break;
                case "Sao Tome and Principe":
                    abb = "STP";
                    break;
                case "Saudi Arabia":
                    abb = "SAU";
                    break;
                case "Senegal":
                    abb = "SEN";
                    break;
                case "Seychelles":
                    abb = "SYC";
                    break;
                case "Sierra Leone":
                    abb = "SLE";
                    break;
                case "Singapore":
                    abb = "SGP";
                    break;
                case "Slovakia":
                    abb = "SVK";
                    break;
                case "Slovenia":
                    abb = "SVN";
                    break;
                case "Solomon Islands":
                    abb = "SLB";
                    break;
                case "Somalia":
                    abb = "SOM";
                    break;
                case "South Africa":
                    abb = "ZAF";
                    break;
                case "South Georgia and the South Sandwich Island":
                    abb = "SGS";
                    break;
                case "Spain":
                    abb = "ESP";
                    break;
                case "Sri Lanka":
                    abb = "LKA";
                    break;
                case "Sudan":
                    abb = "SDN";
                    break;
                case "Suriname":
                    abb = "SUR";
                    break;
                case "Svalbard and Jan Mayen Islands":
                    abb = "SJM";
                    break;
                case "Swaziland":
                    abb = "SWZ";
                    break;
                case "Sweden":
                    abb = "SWE";
                    break;
                case "Switzerland":
                    abb = "CHE";
                    break;
                case "Syrian Arab Republic":
                    abb = "SYR";
                    break;
                case "Taiwan Province of China":
                    abb = "TWN";
                    break;
                case "Tajikistan":
                    abb = "TJK";
                    break;
                case "Thailand":
                    abb = "THA";
                    break;
                case "The former Yugoslav Republic of Macedonia":
                    abb = "MKD";
                    break;
                case "Togo":
                    abb = "TGO";
                    break;
                case "Tokelau":
                    abb = "TKL";
                    break;
                case "Tonga":
                    abb = "TON";
                    break;
                case "Trinidad and Tobago":
                    abb = "TTO";
                    break;
                case "Tunisia":
                    abb = "TUN";
                    break;
                case "Turkey":
                    abb = "TUR";
                    break;
                case "Turkmenistan":
                    abb = "TKM";
                    break;
                case "Turks and Caicos Islands":
                    abb = "TCA";
                    break;
                case "Tuvalu":
                    abb = "TUV";
                    break;
                case "Uganda":
                    abb = "UGA";
                    break;
                case "Ukraine":
                    abb = "UKR";
                    break;
                case "United Arab Emirates":
                    abb = "ARE";
                    break;
                case "United Kingdom Citizen":
                    abb = "GBR";
                    break;
                case "United Kingdom Dependent territories citizen":
                    abb = "GBD";
                    break;
                case "United Kingdom National (overseas)":
                    abb = "GBN";
                    break;
                case "United Kingdom Overseas citizen":
                    abb = "GBO";
                    break;
                case "United Kingdom Protected Person":
                    abb = "GBP";
                    break;
                case "United Kingdom Subject":
                    abb = "GBS";
                    break;
                case "United Republic of Tanzania":
                    abb = "TZA";
                    break;
                case "United States of America":
                    abb = "USA";
                    break;
                case "United States of America Minor Outlying Islands":
                    abb = "UMI";
                    break;
                case "Uruguay":
                    abb = "URY";
                    break;
                case "Uzbekistan":
                    abb = "UZB";
                    break;
                case "Vanuatu":
                    abb = "VUT";
                    break;
                case "Venezuela":
                    abb = "VEN";
                    break;
                case "Viet Nam":
                    abb = "VNM";
                    break;
                case "Virgin Islands (Great Britian)":
                    abb = "VGB";
                    break;
                case "Virgin Islands (United States)":
                    abb = "VIR";
                    break;
                case "Wallis and Futuna Islands":
                    abb = "WLF";
                    break;
                case "Western Sahara":
                    abb = "ESH";
                    break;
                case "Yemen":
                    abb = "YEM";
                    break;
                case "Zaire":
                    abb = "ZAR";
                    break;
                case "Zambia":
                    abb = "ZMB";
                    break;
                case "Zimbabwe":
                    abb = "ZWE";
                    break;
                case "amended by 1967 protocol)":
                    abb = "XXB";
                    break;
                case "Refugee (non-convention)":
                    abb = "XXC";
                    break;
                case "Unspecified / Unknown":
                    abb = "XXX";
                    break;
            }
            return abb;
        }
        private void radio_idcard_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_idcard.Checked)
            {
                label10.Text = "ID Number";
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                txt_firstname.Text = txt_lastname.Text = txt_passportnumber.Text = txt_optional.Text = combo_birthcountry.Text = combo_issuecountry.Text = "";
                line1.Text = line2.Text = line3.Text = "";
                label2.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                line1.Hide();
                line2.Hide();
                line3.Hide();
            }
            else if (radio_passport.Checked)
            {
                label10.Text = "Passport Number";
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                txt_firstname.Text = txt_lastname.Text = txt_passportnumber.Text = txt_optional.Text = combo_birthcountry.Text = combo_issuecountry.Text = "";
                line1.Text = line2.Text = line3.Text = "";
                label2.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                line1.Hide();
                line2.Hide();
                line3.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radio_passport.Checked == true)
            {
                if (txt_firstname.Text == "" || txt_lastname.Text == "" || txt_passportnumber.Text == "" || combo_birthcountry.Text == "" || combo_issuecountry.Text == "")
                {
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;
                    MessageBox.Show("Some Information Is Missing", "ERROR");
                    if (txt_firstname.Text == "")
                    {
                        label4.ForeColor = Color.Red;
                    }
                    if (txt_lastname.Text == "")
                    {
                        label5.ForeColor = Color.Red;
                    }
                    if (txt_passportnumber.Text == "")
                    {
                        label10.ForeColor = Color.Red;
                    }
                    if (combo_birthcountry.Text == "")
                    {
                        label8.ForeColor = Color.Red;
                    }
                    if (combo_issuecountry.Text == "")
                    {
                        label1.ForeColor = Color.Red;
                    }
                }
                else
                {
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;
                    label2.Show();
                    line1.Show();
                    line2.Show();
                    pictureBox1.Show();
                    pictureBox2.Show();
                    pictureBox3.Show();
                    line1.Text = "";
                    line2.Text = "";
                    addition = "";
                    birthdate = date_birthdate.Value.Date.ToString("yyMMdd");
                    expiredate = date_expiration.Value.Date.ToString("yyMMdd");                    
                    //Code for first line in passport
                    firstname = txt_firstname.Text;
                    if (fHasSpace = firstname.Contains(" "))
                    {
                        string[] words = firstname.Split(' ');
                        for (int l = 0; l < (words.Length - 1); l++)
                        {
                            words[0] += "<" + words[l + 1] + "<";
                        }
                        firstname = words[0];
                    }
                    countryabb_birth = Countabb(combo_birthcountry.Text);
                    mrz_line1 = "P<" + countryabb_birth + txt_lastname.Text.ToUpper() + "<<" + firstname.ToUpper();
                    int firstlinelength;
                    firstlinelength = mrz_line1.Length;
                    for (int i = 0; i < (44 - firstlinelength); i++)
                    {
                        mrz_line1 += "<";
                    }
                    line1.Text = mrz_line1;                    
                    //Code for second line in passport
                    if (radio_male.Checked == true)
                    {
                        sex = "M";
                    }
                    else if (radio_female.Checked == true)
                    {
                        sex = "F";
                    }
                    checkdigit1 = CheckDigit(txt_passportnumber.Text.ToUpper());
                    checkdigit2 = CheckDigit(birthdate);
                    checkdigit3 = CheckDigit(expiredate);
                    countryabb_issue = Countabb(combo_issuecountry.Text);
                    if (checkBox_include.Checked)
                    {
                        optional = txt_optional.Text.ToUpper();
                    }
                    else
                    {
                        optional = "";
                    }
                    mrz_line2 = txt_passportnumber.Text.ToUpper() + Convert.ToString(checkdigit1) + countryabb_issue + birthdate + Convert.ToString(checkdigit2) + sex + expiredate + Convert.ToString(checkdigit3) + optional;
                    int line2_len = mrz_line2.Length;
                    for (int j = 0; j < (42 - line2_len); j++)
                    {
                        addition += "<";
                    }
                    checkdigit4 = CheckDigit(optional + addition);
                    longline = txt_passportnumber.Text.ToUpper() + Convert.ToString(checkdigit1) + birthdate + Convert.ToString(checkdigit2) + expiredate + Convert.ToString(checkdigit3) + optional + addition + Convert.ToString(checkdigit4);
                    checkdigit5 = CheckDigit(longline);
                    line2.Text = mrz_line2 + addition + Convert.ToString(checkdigit4) + Convert.ToString(checkdigit5);
                }
            }
            else if (radio_idcard.Checked == true)
            {
                if (txt_firstname.Text == "" || txt_lastname.Text == "" || txt_passportnumber.Text == "" || combo_birthcountry.Text == "" || combo_issuecountry.Text == "")
                {
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;
                    MessageBox.Show("Some Information Is Missing", "ERROR");
                    if (txt_firstname.Text == "")
                    {
                        label4.ForeColor = Color.Red;
                    }
                    if (txt_lastname.Text == "")
                    {
                        label5.ForeColor = Color.Red;
                    }
                    if (txt_passportnumber.Text == "")
                    {
                        label10.ForeColor = Color.Red;
                    }
                    if (combo_birthcountry.Text == "")
                    {
                        label8.ForeColor = Color.Red;
                    }
                    if (combo_issuecountry.Text == "")
                    {
                        label1.ForeColor = Color.Red;
                    }
                }
                else
                {
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;
                    label2.Show();
                    line1.Show();
                    line2.Show();
                    line3.Show();
                    pictureBox1.Show();
                    pictureBox2.Show();
                    pictureBox3.Show();
                    line1.Text = "";
                    line2.Text = "";
                    line3.Text = "";
                    addition = "";
                    birthdate = date_birthdate.Value.Date.ToString("yyMMdd");
                    expiredate = date_expiration.Value.Date.ToString("yyMMdd");
                    //Code for first line in ID
                    if (checkBox_include.Checked)
                    {
                        optional = txt_optional.Text.ToUpper();
                    }
                    else
                    {
                        optional = "";
                    }
                    checkdigit1 = CheckDigit(txt_passportnumber.Text.ToUpper());
                    mrz_line1 = "ID" + Countabb(combo_issuecountry.Text) + txt_passportnumber.Text.ToUpper() + checkdigit1 + optional;
                    int firstlinelength;
                    firstlinelength = mrz_line1.Length;
                    for (int i = 0; i < (30 - firstlinelength); i++)
                    {
                        mrz_line1 += "<";
                    }
                    line1.Text = mrz_line1;
                    //Code for second line in ID
                    if (radio_male.Checked == true)
                    {
                        sex = "M";
                    }
                    else if (radio_female.Checked == true)
                    {
                        sex = "F";
                    }
                    checkdigit2 = CheckDigit(birthdate.ToUpper());
                    checkdigit3 = CheckDigit(expiredate.ToUpper());
                    mrz_line2 = birthdate + checkdigit2 + sex + expiredate + checkdigit3 + Countabb(combo_birthcountry.Text);
                    int secondlinelength;
                    secondlinelength = mrz_line2.Length;
                    for (int i = 0; i < (29 - secondlinelength); i++)
                    {
                        mrz_line2 += "<";
                    }
                    checkdigit4 = CheckDigit(line1.Text.Substring(5, 25) + birthdate + checkdigit2 + expiredate + checkdigit3);
                    line2.Text = mrz_line2 + checkdigit4;
                    //Code for third line in ID
                    firstname = txt_firstname.Text;
                    if (fHasSpace = firstname.Contains(" "))
                    {
                        string[] words = firstname.Split(' ');
                        for (int l = 0; l < (words.Length - 1); l++)
                        {
                            words[0] += "<" + words[l + 1] + "<";
                        }
                        firstname = words[0];
                    }
                    mrz_line3 = txt_lastname.Text.ToUpper() + "<<" + firstname.ToUpper();
                    int thirdlinelength;
                    thirdlinelength = mrz_line3.Length;
                    for (int i = 0; i < (30 - thirdlinelength); i++)
                    {
                        mrz_line3 += "<";
                    }
                    line3.Text = mrz_line3;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txt_firstname.Text = txt_lastname.Text = txt_passportnumber.Text = txt_optional.Text = combo_birthcountry.Text = combo_issuecountry.Text = "";
            line1.Text = line2.Text = line3.Text = "";
            label2.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            line1.Hide();
            line2.Hide();
            line3.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            line2.ForeColor = Color.Black;
            line3.ForeColor = Color.Black;
            Clipboard.Clear();
            Clipboard.SetText(line1.Text);
            line1.ForeColor = Color.LightGreen;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            line1.ForeColor = Color.Black;
            line3.ForeColor = Color.Black;
            Clipboard.Clear();
            Clipboard.SetText(line2.Text);
            line2.ForeColor = Color.LightGreen;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            line1.ForeColor = Color.Black;
            line2.ForeColor = Color.Black;
            Clipboard.Clear();
            Clipboard.SetText(line3.Text);
            line3.ForeColor = Color.LightGreen;
        }
    }
}