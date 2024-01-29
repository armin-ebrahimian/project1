using Project;
using System;

namespace Project
{
    class Discount
    {
        //فیلد 
        private int n;
        private string t;
        private string[] ary;

        //خاصیت
        public int N
        {
            get { return n; }
            set
            {
                if (value > 0)
                {
                    n = value;
                }
            }
        }
        public string T
        {
            get { return t; }
            set { t = value; }
        }
        public string[] Ary
        {
            get { return ary; }
            set { ary = value; }
        }
        //مخرب
        public Discount() { }
        //سازنده
        public Discount(string[] Ary, int N , string T)
        {

            ary = Ary;
            n = N;
            t = T;
        }
        //متدی که داخل مین بر میگردد 
        public string[] Show()
        {
            //تعداد را داخل متغیر ایکس میریزیم
            int x = n;
            //تعریف لیست از جنس استیرینگ برای ذخیره جواب ها
            List<string> pas = new List<string>();
            //حلقه به تعداد کدی که از کاربر میگیریم
            for (int i = 0; i < x; i++)
            {
                //بررسی هر کد تخفیف که قراره چک بشه
                string check = ary[i];
                //بررسی اندازه کارکتر کد تخفیفی که قراره چک بشه
                int y = check.Length;
                //برای برسی صحیح و غلط بودن کد 
                int core = 1;
                // حلقه به اندازه کد تخفیف دوم ادامه پیدا میکند 
                for (int j = 0; j < y; j++)
                {
                    //هر کارکتر کد تخفیف که قرار برسی بشه جدا میشه و داخل سی ریخته میشه
                    string c = check.Substring(j, 1);
                    //در این شرط بررسی میکند که اگر هر کارکتر داخل کد اصلی نبود
                    //و غلط بود متغیر کره که برای برسی ما هست را برابر 0 قرار میدهد
                    if (t.Contains(c) == false)
                    {
                        core = 0;
                        //اگر یک کلمه نبود 0 را چاپ میکند و حلقه را میبندد
                        break;
                    }
                }
                //اگر برابر 0 بود نه در لیست ذخیره میشود
                if (core == 0)
                {
                    pas.Add("no");
                }
                // اگر برابر 1 که اول برنامه بود اره در لیست ذخیره میشود
                else
                {
                    pas.Add("yes");
                }

            }//برای ریترن کردن آرایه
            string[] yn;
            //برابر کردن مقدار لیست با آرایه
            yn = pas.ToArray();
            //برگرداندن آرایه yn
            return yn;
        }
    }

    class Test
    {
        public static void Main()
        {
            //تکرار از کاربر
            Console.WriteLine("tedad ra vared konid");
            int n = int.Parse(Console.ReadLine());

            //کد تخفیف
            Console.WriteLine("kode takhfif ra vared konid");
            string t = Console.ReadLine();

            // آرایه استیرینگ به سایز دریافتی از کاربر 
            string[] ary = new string[n];

            //دریافت کد تخفیف ها 
            Console.WriteLine("code ha ra vard konid .");
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + 1 + " ) ");
                ary[i] = Console.ReadLine();
            }

            //معرفی کردن کلاس شی گرایی
            Discount c1 = new Discount();

            //مقداردهی کد هایی که قراره تست بشن 
            c1.Ary = ary;

            //مقدار دهی اعداد تکرار
            c1.N = n;

            //مقدار دهی کد تخفیف اصلی
            c1.T = t;

            //جواب ها که از متد ریترن میشوند داخله این آرایه ریخته میشود
            string[] ans = c1.Show();
            Console.WriteLine("vaziat kode ha ");
            //برای چاپ جواب ها 
            for (int j = 0; j < n; j++)

            {
                Console.WriteLine(j+1 + " ) "+ans[j]);
            }
        }
    }
}
