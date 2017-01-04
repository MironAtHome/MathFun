using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFun
{
    class Addition
    {
        static void Main(string[] args)
        {
            try
            {
                float v1 = float.MaxValue;
                float v2 = float.MaxValue;
                Console.WriteLine("Type: {0}", v1.GetType().Name);
                Console.WriteLine("1. Value of v1 = {0}", v1);
                v1 = v2+v1;
                Console.WriteLine("2. Value of v1 = {0}", v1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                double v1 = double.MaxValue;
                double v2 = double.MaxValue;
                Console.WriteLine("Type: {0}", v1.GetType().Name);
                Console.WriteLine("1. Value of v1 = {0}", v1);
                v1 = v2+v1;
                Console.WriteLine("2. Value of v1 = {0}", v1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                decimal v1 = decimal.MaxValue;
                decimal v2 = decimal.MaxValue;
                Console.WriteLine("Type: {0}", v1.GetType().Name);
                Console.WriteLine("1. Value of v1 = {0}", v1);
                v1 = v2+v1;
                Console.WriteLine("2. Value of v1 = {0}", v1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                uint v1 = uint.MaxValue;
                uint v2 = uint.MaxValue;
                Console.WriteLine("Type: {0}", v1.GetType().Name);
                Console.WriteLine("1. Value of v1 = {0}", v1);
                v1 = v2+v1;
                Console.WriteLine("2. Value of v1 = {0}", v1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                int v1 = int.MaxValue;
                int v2 = int.MaxValue;
                Console.WriteLine("Type: {0}", v1.GetType().Name);
                Console.WriteLine("1. Value of v1 = {0}", v1);
                v1 = v2+v1;
                Console.WriteLine("2. Value of v1 = {0}", v1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                short v1 = short.MaxValue;
                short v2 = short.MaxValue;
                Console.WriteLine("Type: {0}", v1.GetType().Name);
                Console.WriteLine("1. Value of v1 = {0}", v1);
                v1 = (short)(v2+v1);
                Console.WriteLine("2. Value of v1 = {0}", v1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                ushort v1 = ushort.MaxValue;
                ushort v2 = ushort.MaxValue;
                Console.WriteLine("Type: {0}", v1.GetType().Name);
                Console.WriteLine("1. Value of v1 = {0}", v1);
                v1 = (ushort)(v2+v1);
                Console.WriteLine("2. Value of v1 = {0}", v1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                long v1 = long.MaxValue;
                long v2 = long.MaxValue;
                Console.WriteLine("Type: {0}", v1.GetType().Name);
                Console.WriteLine("1. Value of v1 = {0}", v1);
                v1 = (long)v2+v1;
                Console.WriteLine("2. Value of v1 = {0}", v1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                ulong v1 = ulong.MaxValue;
                ulong v2 = ulong.MaxValue;
                Console.WriteLine("Type: {0}", v1.GetType().Name);
                Console.WriteLine("1. Value of v1 = {0}", v1);
                v1 = (ulong)v2+v1;
                Console.WriteLine("2. Value of v1 = {0}", v1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                byte v1 = byte.MaxValue;
                byte v2 = byte.MaxValue;
                Console.WriteLine("Type: {0}", v1.GetType().Name);
                Console.WriteLine("1. Value of v1 = {0}", v1);
                v1 = (byte)(v2+v1);
                Console.WriteLine("2. Value of v1 = {0}", v1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
            try
            {
                sbyte v1 = sbyte.MaxValue;
                sbyte v2 = sbyte.MaxValue;
                Console.WriteLine("Type: {0}", v1.GetType().Name);
                Console.WriteLine("1. Value of v1 = {0}", v1);
                v1 = (sbyte)(v2+v1);
                Console.WriteLine("2. Value of v1 = {0}", v1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
            }
        }
    }
}
