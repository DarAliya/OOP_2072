using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drobi
{
    
    class Rational
    {
        int ch;
        int zn;

        public Rational()
        {
            ch = 0;
            zn = 1;
        }
        public Rational(int ch, int zn)
        {
            this.ch = ch;
            this.zn = zn;
        }
        static int GCD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                while (b != 0)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }

                return a;
            }
        }      

        public override string ToString()
        {
            string s = Convert.ToString(ch);
            s += "/";
            s += Convert.ToString(zn);
            return s;
        }
        public Rational summa(Rational other)
        {
            int resultch = ch * other.zn + other.ch * zn;
            int resultzn = zn * other.zn;
            int t = GCD(resultch, resultzn);
            resultch /= t;
            resultzn /= t;
            Rational r = new Rational(resultch, resultzn);
            return r;
        }
        public Rational minus(Rational other)
        {
            int resultch = ch * other.zn - other.ch * zn;
            int resultzn = zn * other.zn;
            int t = GCD(resultch, resultzn);
            resultch /= t;
            resultzn /= t;
            Rational r = new Rational(resultch, resultzn);
            return r;
        }
        public Rational delenie(Rational other)
        {
            int resultch = ch * other.zn;
            int resultzn = other.ch * zn;
            int t = GCD(resultch, resultzn);
            resultch /= t;
            resultzn /= t;
            Rational r = new Rational(resultch, resultzn);
            return r;
        }
        public Rational umnozh(Rational other)
        {
            int resultch = ch * other.ch;
            int resultzn = other.zn * zn;
            int t = GCD(resultch, resultzn);
            resultch /= t;
            resultzn /= t;
            Rational r = new Rational(resultch, resultzn);
            return r;
        }
        public static Rational operator +(Rational r1, Rational r2)
        {
            return r1.summa(r2);
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            return r1.minus(r2);
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            return r1.umnozh(r2);
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            return r1.delenie(r2);
        }
    }
}
