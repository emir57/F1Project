using Microsoft.EntityFrameworkCore;
using f1project.data.Concrete.EfCore;
using System.Linq;
using System.Collections.Generic;
using f1project.entity.Concrete;
using System;

namespace f1project.data.SeedDatabase
{
    public static class DataSeeding
    {
        public static void Seed()
        {
            var context = new F1ProjectContext();
            context.Database.Migrate();
            if(context.Countries.Count()==0)
            {
                var countries = new List<Country>();
                countries.Add(new Country{CountryName="Avustralya",CountryImageUrl="australia_flag.png"});
                countries.Add(new Country{CountryName="Kanada",CountryImageUrl="canada_flag.png"});
                countries.Add(new Country{CountryName="Birleşik Krallık",CountryImageUrl="england_flag.png"});
                countries.Add(new Country{CountryName="Finlandiya",CountryImageUrl="finland_flag.png"});
                countries.Add(new Country{CountryName="Fransa",CountryImageUrl="france_flag.png"});
                countries.Add(new Country{CountryName="Almanya",CountryImageUrl="germany_flag.png"});
                countries.Add(new Country{CountryName="Hollanda",CountryImageUrl="holland_flag.png"});
                countries.Add(new Country{CountryName="İtalya",CountryImageUrl="italy_flag.png"});
                countries.Add(new Country{CountryName="Japonya",CountryImageUrl="Japan_flag.png"});
                countries.Add(new Country{CountryName="Meksika",CountryImageUrl="mexico_flag.png"});
                countries.Add(new Country{CountryName="Monaco",CountryImageUrl="monaco_flag.png"});
                countries.Add(new Country{CountryName="Rusya",CountryImageUrl="russia_flag.png"});
                countries.Add(new Country{CountryName="İspanya",CountryImageUrl="spain_flag.png"});
                context.AddRange(countries);
                context.SaveChangesAsync();
            }
            if(context.Teams.Count()==0)
            {
                var teams = new List<F1Team>();
                teams.Add(new F1Team{Name="Alfa Romeo Racing",Founder="Nicola Romeo,Alexandre Darracq,Ugo Stella",FoundationYear=new DateTime(1910,6,24),TeamBoss="Frédéric Vasseur",TeamImageUrl="alfaromeo_team.png"});
                teams.Add(new F1Team{Name="AlphaTauri",Founder="Dietrich Mateschitz",FoundationYear=new DateTime(2016,1,1),TeamBoss="Graham Watson",TeamImageUrl="alphatauri_team.png"});
                teams.Add(new F1Team{Name="Alpine",Founder="Luca De Meo",FoundationYear=new DateTime(1955,6,25),TeamBoss="Cyril Abiteboul",TeamImageUrl="alpine_team.png"});
                teams.Add(new F1Team{Name="Aston Martin",Founder="Martin Whitmarsh",FoundationYear=new DateTime(2019,1,1),TeamBoss="Otmar Szafnauer",TeamImageUrl="astonmartin_team.png"});
                teams.Add(new F1Team{Name="Ferrari",Founder="Enzo Ferrari",FoundationYear=new DateTime(1929,11,16),TeamBoss="Mattia Binotto",TeamImageUrl="ferrari_team.png"});
                teams.Add(new F1Team{Name="Haas F1 Team",Founder="Gene Haas",FoundationYear=new DateTime(2014,4,1),TeamBoss="Guenther Steiner",TeamImageUrl="haas_team.png"});
                teams.Add(new F1Team{Name="McLaren",Founder="Bruce McLaren",FoundationYear=new DateTime(1963,9,2),TeamBoss="Zak Brown",TeamImageUrl="mclaren_team.png"});
                teams.Add(new F1Team{Name="Mercedes",Founder="Alfred Neubauer",FoundationYear=new DateTime(2010,1,1),TeamBoss="Toto Wolff",TeamImageUrl="mercedes_team.png"});
                teams.Add(new F1Team{Name="Red Bull Racing",Founder="Dietrich Mateschitz",FoundationYear=new DateTime(2004,1,1),TeamBoss="Christian Horner OBE",TeamImageUrl="redbull_team.png"});
                teams.Add(new F1Team{Name="Williams Racing",Founder="Frank Williams,Patrick Head",FoundationYear=new DateTime(1977,1,1),TeamBoss="Simon Roberts",TeamImageUrl="williams_team.png"});
                context.Teams.AddRange(teams);
                context.SaveChangesAsync();
            }
            if(context.Drivers.Count()==0)
            {
                var drivers = new List<F1Driver>();
                drivers.Add(new F1Driver{DriverName="Daniel",DriverSurname="Ricciardo",DriverNumber=3,TeamId=7,DateOfBirth=new DateTime(1989,07,01),CountryId=1,DriverImageUrl="daniel_ricciardo.png"});
                drivers.Add(new F1Driver{DriverName="Lando",DriverSurname="Norris",DriverNumber=4,TeamId=7,DateOfBirth=new DateTime(1999,11,13),CountryId=3,DriverImageUrl="lando_norris.png"});
                drivers.Add(new F1Driver{DriverName="Sebastian",DriverSurname="Vettel",DriverNumber=5,TeamId=4,DateOfBirth=new DateTime(1987,07,03),CountryId=6,DriverImageUrl="sebastian_vettel.png"});
                drivers.Add(new F1Driver{DriverName="Nicholas",DriverSurname="Latifi",DriverNumber=6,TeamId=10,DateOfBirth=new DateTime(1995,06,29),CountryId=2,DriverImageUrl="nicholas_latifi.png"});
                drivers.Add(new F1Driver{DriverName="Kimi",DriverSurname="Taikkonen",DriverNumber=7,TeamId=1,DateOfBirth=new DateTime(1979,10,17),CountryId=4,DriverImageUrl="kimi_raikkonen.png"});
                drivers.Add(new F1Driver{DriverName="Nikita",DriverSurname="Mazepin",DriverNumber=9,TeamId=6,DateOfBirth=new DateTime(1999,03,02),CountryId=12,DriverImageUrl="nikita_mazepin.png"});
                drivers.Add(new F1Driver{DriverName="Pierre",DriverSurname="Gasly",DriverNumber=10,TeamId=2,DateOfBirth=new DateTime(1996,02,07),CountryId=5,DriverImageUrl="pierre_gasly.png"});
                drivers.Add(new F1Driver{DriverName="Sergio",DriverSurname="Perez",DriverNumber=11,TeamId=9,DateOfBirth=new DateTime(1990,01,26),CountryId=10,DriverImageUrl="sergio_perez.png"});
                drivers.Add(new F1Driver{DriverName="Fernando",DriverSurname="Alonso",DriverNumber=14,TeamId=3,DateOfBirth=new DateTime(1981,07,29),CountryId=13,DriverImageUrl="fernando_alonso.png"});
                drivers.Add(new F1Driver{DriverName="Charles",DriverSurname="Leclerc",DriverNumber=16,TeamId=5,DateOfBirth=new DateTime(1997,10,16),CountryId=11,DriverImageUrl="charles_leclerc.png"});
                drivers.Add(new F1Driver{DriverName="Lance",DriverSurname="Stroll",DriverNumber=18,TeamId=4,DateOfBirth=new DateTime(1998,10,29),CountryId=2,DriverImageUrl="lance_stroll.png"});
                drivers.Add(new F1Driver{DriverName="Yuki",DriverSurname="Tsunoda",DriverNumber=22,TeamId=2,DateOfBirth=new DateTime(2000,05,11),CountryId=9,DriverImageUrl="yuki_tsunoda.png"});
                drivers.Add(new F1Driver{DriverName="Esteban",DriverSurname="Ocon",DriverNumber=31,TeamId=3,DateOfBirth=new DateTime(1996,09,17),CountryId=5,DriverImageUrl="esteban_ocon.png"});
                drivers.Add(new F1Driver{DriverName="Max",DriverSurname="Verstappen",DriverNumber=33,TeamId=9,DateOfBirth=new DateTime(1997,09,30),CountryId=7,DriverImageUrl="max_verstappen.png"});
                drivers.Add(new F1Driver{DriverName="Lewis",DriverSurname="Hamilton",DriverNumber=44,TeamId=8,DateOfBirth=new DateTime(1985,01,07),CountryId=3,DriverImageUrl="lewis_hamilton.png"});
                drivers.Add(new F1Driver{DriverName="Mick",DriverSurname="Schumacher",DriverNumber=47,TeamId=6,DateOfBirth=new DateTime(1999,03,22),CountryId=6,DriverImageUrl="mick_schumacher.png"});
                drivers.Add(new F1Driver{DriverName="Carlos",DriverSurname="Sainz Jr.",DriverNumber=55,TeamId=5,DateOfBirth=new DateTime(1994,09,01),CountryId=13,DriverImageUrl="carlos_sainz.png"});
                drivers.Add(new F1Driver{DriverName="George",DriverSurname="Russell",DriverNumber=63,TeamId=10,DateOfBirth=new DateTime(1998,02,15),CountryId=3,DriverImageUrl="george_russell.png"});
                drivers.Add(new F1Driver{DriverName="Valtteri",DriverSurname="Bottas",DriverNumber=77,TeamId=8,DateOfBirth=new DateTime(1989,08,28),CountryId=4,DriverImageUrl="valtteri_bottas.png"});
                drivers.Add(new F1Driver{DriverName="Antonio",DriverSurname="Giovinazzi",DriverNumber=99,TeamId=1,DateOfBirth=new DateTime(1993,12,14),CountryId=8,DriverImageUrl="antonio_giovinazzi.png"});
                context.Drivers.AddRange(drivers);
                context.SaveChangesAsync();
            }

        }
    }
}