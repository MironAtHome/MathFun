namespace MathFun
{
    using System;
    class Division
    {
        static void Main(string[] args)
        {
            try
            {
                float de = 0;
                float nu = 1;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = nu/de;
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                double de = 0;
                double nu = 1;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = nu/de;
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                decimal de = 0;
                decimal nu = 1;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = nu/de;
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                uint de = 0;
                uint nu = 1;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = nu/de;
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                int de = 0;
                int nu = 1;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = nu/de;
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                short de = 0;
                short nu = 1;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = (short)(nu/de);
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                ushort de = 0;
                ushort nu = 1;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = (ushort)(nu/de);
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                long de = 0;
                long nu = 1;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = (long)nu/de;
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                ulong de = 0;
                ulong nu = 1;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = (ulong)nu/de;
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                byte de = 0;
                byte nu = 1;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = (byte)(nu/de);
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                sbyte de = 0;
                sbyte nu = 1;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = (sbyte)(nu/de);
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
        }
    }
}
