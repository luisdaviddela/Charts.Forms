using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;
using Entry = Microcharts.Entry;
namespace Charts.Forms_Demo
{
    public class Microcharts_Data
    {
        public List<Entry> GetChart()
        {
            List<Entry> data = new List<Entry>
        {
            new Entry(1563532)
            {
                Label = "01 Ene 16",
                ValueLabel ="1563532",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
            new Entry(2919064)
            {
                Label = "02 Feb 16",
                ValueLabel ="2919064",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
            new Entry(2922564)
            {
                Label = "03 Mar 16",
                ValueLabel ="2922564",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
            new Entry(4495396)
            {
                Label = "04 Abr 16",
                ValueLabel ="4495396",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
            new Entry(6086428)
            {
                Label = "05 May 16",
                ValueLabel ="6086428",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
            new Entry(7646260)
            {
                Label = "06 Jun 16",
                ValueLabel ="7646260",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
            new Entry(8526092)
            {
                Label = "07 Jul 16",
                ValueLabel ="8526092",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
            new Entry(9905924)
            {
                Label = "08 Ago 16",
                ValueLabel ="9905924",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),            },
            new Entry(10923090)
            {
                Label = "09 Sep 16",
                ValueLabel ="10923090",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
            new Entry(12052922)
            {
                Label = "10 Oct 16",
                ValueLabel ="12052922",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
            new Entry(13052754)
            {
                Label = "11 Nov 16",
                ValueLabel ="13052754",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
            new Entry(14052586)
            {
                Label = "12 Dic 16",
                ValueLabel ="14052586",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
            new Entry(14088586)
            {
                Label = "01 Ene 17",
                ValueLabel ="14088586",
                Color = SKColor.Parse("#2E4053"),
                TextColor = SKColor.Parse("#DF013A"),
            },
        };

            return data;
        }
    }
}
