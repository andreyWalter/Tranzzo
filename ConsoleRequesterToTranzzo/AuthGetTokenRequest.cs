using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRequesterToTranzzo
{
    public class AuthGetTokenRequest
    {
        public string pos_id { get; set; }                              //"XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX", (mandatory) 

        public string mode { get; set; } = "direct";                    //"mode":"direct", (mandatory)

        public string method { get; set; } = "auth";                    //"auth", (mandatory) 

        public decimal amount { get; set; } = 10.11m;                   //"amount":10.11, (mandatory) 

        public string currency { get; set; } = "UAH";                   //"UAH", (mandatory) 

        public string description { get; set; } = "Get catd token";     //"description":"description text", (mandatory) 

        public string order_id { get; set; }                            //"order_id" : "Merchant_Order_id_111", (mandatory)

        public string order_3ds_bypass { get; set; } = "supported";     //"order_3ds_bypass":"supported","always","never" ​(mandatory)  

        public string payway { get; set; } = "cc";                      //"cc", "privat24"  

        public string cc_number { get; set; }                              //"111111111111111", 

        public int exp_month { get; set; }                              //"3", 

        public int exp_year { get; set; }                               //"21", 

        public int card_cvv { get; set; }                               //"111", 

        public string merchant_mcc { get; set; }                           //"4018", 

        public string customer_id { get; set; }                         // "merchant_customer_id", (mandatory) 

        public string customer_email { get; set; }                      //  "email212 @email.com", (mandatory)  

        public string customer_fname { get; set; }                      //  "John", 

        public string customer_lname { get; set; }                      //  "Doe", 

        public string customer_phone { get; set; }                      //  "202-318-0835", 

        public object payload { get; set; }                             //  "Additional data in JSON format" 

        //public payload payload { get; set; }                             //  "Additional data in JSON format" 

        public string server_url { get; set; }                          //  "http://www.merchant-website.com/callback.php", (mandatory) 

        public string result_url { get; set; }                          //  "http://www.merchant-website.com/result.php" (mandatory)  

        public object[] products { get; set; } = new object[1];
    }
}
