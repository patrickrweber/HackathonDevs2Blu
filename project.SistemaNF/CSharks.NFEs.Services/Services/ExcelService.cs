﻿using CSharks.NFEs.Domain.DTOs;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Models.NF_UTILS;
using CSharks.NFEs.Services.Interfaces;
using ExcelDataReader;

namespace CSharks.NFEs.Services.Services
{
    public class ExcelService : IExcel
    {
        public List<ISQN> ReadISQNFromExcel(string pathFile)
        {
            List<ISQN> Isqns = new List<ISQN>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(pathFile, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    int counter = 0;

                    while (reader.Read())
                    {

                        if (counter >= 2)
                        {
                            Isqns.Add(new ISQN
                            {
                                Code = reader.GetValue(0).ToString()!,
                                Description = reader.GetValue(1).ToString()!,
                                Aliquot = reader.GetValue(2).ToString()!

                            });
                        }

                        counter++;
                    }
                }

                return Isqns;
            }
        }

        public List<TOMDTO> ReadTOMFromExcel(string pathFile)
        {
            List<TOMDTO> toms = new List<TOMDTO>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(pathFile, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    int counter = 0;

                    while (reader.Read())
                    {

                        if (counter >= 1 && counter < 5570)
                        {
                            toms.Add(new TOMDTO
                            {
                                tom = reader.GetValue(0).ToString()!,
                                name = reader.GetValue(1).ToString()!,

                            });
                        }

                        counter++;
                    }
                }

                return toms;
            }
        }
    }
}
