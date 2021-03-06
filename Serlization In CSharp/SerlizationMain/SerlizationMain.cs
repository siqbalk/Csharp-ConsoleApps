﻿using Handler;
using Model;
using System;
using System.Collections.Generic;

namespace SerlizationMain
{
    class SerlizationMain
    {
        static void Main(string[] args)
        {
            var person = new List<PersonInf>()
            {
                new PersonInf()
                {
                    PersonId=1,PersonName="Syed",created=DateTime.Now
                },
            new PersonInf()
            {
                PersonId=2,PersonName="Iqbal",created=DateTime.Now
            },
            new PersonInf()
            {
                PersonId=3,PersonName="Nouman",created=DateTime.Now
            }
            };
            string path = @"C:\";
            try
            {
                new XmlSerlizationHandler().Serlization(path, person);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("press any key to quit");
            Console.ReadKey();
        }
    }
}
