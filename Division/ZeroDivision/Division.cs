namespace MathFun
{
    using System;
    class Division
    {
        static void Main(string[] args)
        {
            try
            {
                float de = 1;
                float nu = 0;
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
                double de = 1;
                double nu = 0;
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
                uint de = 1;
                uint nu = 0;
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
                int de = 1;
                int nu = 0;
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
                short de = 1;
                short nu = 0;
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
                ushort de = 1;
                ushort nu = 0;
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
                long de = 1;
                long nu = 0;
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
                ulong de = 1;
                ulong nu = 0;
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
                byte de = 1;
                byte nu = 0;
                Console.WriteLine("Type: {0}", de.GetType().Name);
                Console.WriteLine("1. Value of de = {0}", de);
                de = (byte)(nu/de);
                Console.WriteLine("2. Value of de = {0}", de);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
        }
    }
}
