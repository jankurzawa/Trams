namespace Trams.DATA.Context.Seeders
{
    public static class Seeder
    {
        public static void SeedDataBase(this ModelBuilder modelBuilder)
        {
            List<Vehicle> vehicles = new()
            {
                new Vehicle("52", VehicleType.Tram),
                new Vehicle("22", VehicleType.Tram),
                new Vehicle("1", VehicleType.Tram),
                new Vehicle("24", VehicleType.Tram)
            };

            List<Stop> stopsOf52 = new()
            {
                new Stop("Czerwone Maki", "Loop"),//0
                new Stop("Chmieleniec", "On Ruczaj"),//1
                new Stop("Ruczaj", "On Ruczaj"),//2
                new Stop("Kampus UJ", "UJ"),//3
                new Stop("Norymberska", "Next to Zakrzowek"),//4
                new Stop("Grota Roweckiego", "Intersection with the Kobierzyńska Street"),//5
                new Stop("Lipińskiego", ""),//6
                new Stop("Kobierzyńska", ""),//7
                new Stop("Słomiana", ""),//8
                new Stop("Kapelanka", ""),//9
                new Stop("Szwedzka", ""),//10
                new Stop("Rondo Grunwaldzkie", ""),//11
                new Stop("Orzeszkowej", ""),//12
                new Stop("Stradom", ""),//13
                new Stop("Starowiślna", ""),//14
                new Stop("Poczta Główna", ""),//15
                new Stop("Teatr Słowackiego", ""),//16
                new Stop("Lubicz", ""),//17
                new Stop("Rondo Mogilskie ", ""),//18
                new Stop("Cystersów", ""),//19
                new Stop("Białucha", ""),//20
                new Stop("TAURON Arena Kraków Wieczysta", ""),//21
                new Stop("Muzeum Lotnictwa", ""),//22
                new Stop("AWF", ""),//23
                new Stop("Stella - Sawickiego", ""),//24
                new Stop("Czyżyny", ""),//25
                new Stop("Rondo Czyżyńskie", ""),//26
                new Stop("Bieńczycka", ""),//27
                new Stop("Rondo Kocmyrzowskie im.Ks.Gorzelanego", ""),//28
                new Stop("DH Wanda", ""),//29
                new Stop("Rondo Hipokratesa", ""),//30
                new Stop("Dunikowskiego", ""),//31
                new Stop("Kleeberga", ""),//32
                new Stop("Piasta Kołodzieja", ""),//33
                new Stop("Os.Piastów", "")//34
            };
            List<Stop> stopsOf22 = new()
            {
                new Stop("Borek Fałęcki",""), //0
                new Stop("Borek Fałęcki I",""),//1
                new Stop("Solvay",""),//2
                new Stop("Łagiewniki SKA",""),//3
                new Stop("Łagiewniki",""),//4
                new Stop("Brożka","NŻ"),//5
                new Stop("Borsucza",""),//6
                stopsOf52[7],
                stopsOf52[8],
                stopsOf52[9],
                stopsOf52[10],
                stopsOf52[11],
                stopsOf52[12],
                stopsOf52[13],
                stopsOf52[14],
                new Stop("Hala Targowa",""),//15
                new Stop("Rondo Grzegórzeckie",""),//16
                new Stop("Teatr Variété",""),//17
                new Stop("Francesco Nullo",""),//18
                new Stop("Fabryczna",""),//19
                new Stop("Ofiar Dąbia",""),//20
                new Stop("Dąbie",""),//21
                new Stop("Plaza","NŻ"),//22
                new Stop("TAURON Arena Kraków al.Pokoju",""), //23
                new Stop("M1 al. Pokoju",""),//24
                new Stop("Rondo 308.Dywizjonu",""), //25
                new Stop("Centralna",""),//26
                new Stop("Rondo Czyżyńskie",""),//27
                new Stop("Os.Kolorowe",""),//28
                new Stop("Plac Centralny im.R.Reagana",""),//29
                new Stop("Struga",""),//30
                new Stop("Kombinat",""),//31
                new Stop("Kopiec Wandy",""),//32
            };
            List<Stop> stopsOf1 = new()
            {
                new Stop("Wzgórza Krzesławickie",""),//0
                new Stop("Jarzębiny",""),//1
                new Stop("Darwina",""),//2
                new Stop("Wiadukty",""),//3
                new Stop("Wańkowicza",""),//4
                new Stop("Cienista",""),//5
                new Stop("Teatr Ludowy",""),//6
                new Stop("Rondo Kocmyrzowskie im.Ks.Gorzelanego",""),//7
                stopsOf52[27],//8
                stopsOf52[26],//9
                stopsOf22[26],//10
                stopsOf22[25],//11
                stopsOf22[24],//12
                stopsOf22[23],//13
                stopsOf22[22],//14
                stopsOf22[21],//15
                stopsOf22[20],//16
                stopsOf22[19],//17
                stopsOf22[18],//18
                stopsOf22[17],//19
                stopsOf22[16],//20
                stopsOf22[15],//21
                stopsOf22[14],//22
                stopsOf52[15],//23
                new Stop("Plac Wszystkich Świętych",""),//24
                new Stop("Filharmonia",""),//25
                new Stop("Jubilat",""),//26
                new Stop("Komorowskiego",""),//27
                new Stop("Salwator",""),//28
            };
            List<Stop> stopsOf24 = new()
            {
                new Stop("Kurdwanów P+R",""),//0
                new Stop("Witosa",""),//1
                new Stop("Nowosądecka",""),//2
                new Stop("Piaski Nowe",""),//3
                new Stop("Dauna",""),//4
                new Stop("Bieżanowska",""),//5
                new Stop("Kabel",""),//6
                new Stop("Dworcowa",""),//7
                new Stop("Cmentarz Podgórski",""),//8
                new Stop("Podgórze SKA",""),//9
                new Stop("Plac Bohaterów Getta",""),//10
                new Stop("św.Wawrzyńca",""),//11
                new Stop("Miodowa",""),//12
                stopsOf52[14],//13
                stopsOf52[15],//14
                stopsOf52[16],//15
                new Stop("Stary Kleparz",""),//16
                new Stop("Teatr Bagatela",""),//17
                new Stop("Batorego",""),//18
                new Stop("Plac Inwalidów",""),//19
                new Stop("Urzędnicza",""),//20
                new Stop("Biprostal",""),//21
                new Stop("Uniwersytet Pedagogiczny",""),//22
                new Stop("Głowackiego",""),//23
                new Stop("Bronowice",""),//24
                new Stop("Wesele",""),//25
                new Stop("Bronowice SKA",""),//26
                new Stop("Bronowice Małe",""),//27
            };

            List<VehicleStop> vehicleStops = new();

            Random rand = new Random();
            List<DepartureTime> departureTimes = new();

            //52 => Os.Piastów
            TimeSpan Time = new TimeSpan(4, rand.Next(0, 50), 0);
            int numberOfStop = 1;
            foreach (var stop in stopsOf52)
            {
                var newVehicleStop = new VehicleStop(vehicles[0], stop, numberOfStop, stopsOf52.Last().Name);
                vehicleStops.Add(newVehicleStop);
                TimeSpan tempTime = new TimeSpan(Time.Hours, Time.Minutes, 0);
                for (int j = 0; j < 36; j++)
                {
                    var newDepartureTime = new DepartureTime(tempTime, newVehicleStop);
                    departureTimes.Add(newDepartureTime);
                    tempTime += new TimeSpan(0, 30, 0);
                }
                numberOfStop++;
                Time += new TimeSpan(0, 2, 0);
            }
            //52 => Czerwone Maki
            Time = new TimeSpan(4, rand.Next(0, 50), 0);
            numberOfStop = 1;
            for (int i = stopsOf52.Count - 1; i >= 0; i--)
            {
                var newVehicleStop = new VehicleStop(vehicles[0], stopsOf52[i], numberOfStop, stopsOf52.First().Name);
                vehicleStops.Add(newVehicleStop);
                TimeSpan tempTime = new TimeSpan(Time.Hours, Time.Minutes, 0);
                for (int j = 0; j < 36; j++)
                {
                    var newDepartureTime = new DepartureTime(tempTime, newVehicleStop);
                    departureTimes.Add(newDepartureTime);
                    tempTime += new TimeSpan(0, 30, 0);
                }
                numberOfStop++;
                Time += new TimeSpan(0, 2, 0);
            }
            //22 => Kopiec Wandy
            Time = new TimeSpan(4, rand.Next(0, 50), 0);
            numberOfStop = 1;
            foreach (var stop in stopsOf22)
            {
                var newVehicleStop = new VehicleStop(vehicles[1], stop, numberOfStop, stopsOf22.Last().Name);
                vehicleStops.Add(newVehicleStop);
                TimeSpan tempTime = new TimeSpan(Time.Hours, Time.Minutes, 0);
                for (int j = 0; j < 36; j++)
                {
                    var newDepartureTime = new DepartureTime(tempTime, newVehicleStop);
                    departureTimes.Add(newDepartureTime);
                    tempTime += new TimeSpan(0, 30, 0);
                }
                numberOfStop++;
                Time += new TimeSpan(0, 2, 0);
            }
            //22 => Borek Fałęcki
            Time = new TimeSpan(4, rand.Next(0, 50), 0);
            numberOfStop = 1;
            for (int i = stopsOf22.Count - 1; i >= 0; i--)
            {
                var newVehicleStop = new VehicleStop(vehicles[1], stopsOf22[i], numberOfStop, stopsOf22.First().Name);
                vehicleStops.Add(newVehicleStop);
                TimeSpan tempTime = new TimeSpan(Time.Hours, Time.Minutes, 0);
                for (int j = 0; j < 36; j++)
                {
                    var newDepartureTime = new DepartureTime(tempTime, newVehicleStop);
                    departureTimes.Add(newDepartureTime);
                    tempTime += new TimeSpan(0, 30, 0);
                }
                numberOfStop++;
                Time += new TimeSpan(0, 2, 0);
            }
            //1 => Salwator
            Time = new TimeSpan(4, rand.Next(0, 50), 0);
            numberOfStop = 1;
            foreach (var stop in stopsOf1)
            {
                var newVehicleStop = new VehicleStop(vehicles[2], stop, numberOfStop, stopsOf1.Last().Name);
                vehicleStops.Add(newVehicleStop);
                TimeSpan tempTime = new TimeSpan(Time.Hours, Time.Minutes, 0);
                for (int j = 0; j < 36; j++)
                {
                    var newDepartureTime = new DepartureTime(tempTime, newVehicleStop);
                    departureTimes.Add(newDepartureTime);
                    tempTime += new TimeSpan(0, 30, 0);
                }
                numberOfStop++;
                Time += new TimeSpan(0, 2, 0);
            }
            // 1 => Wzgórza Krzesławickie
            Time = new TimeSpan(4, rand.Next(0, 50), 0);
            numberOfStop = 1;
            for (int i = stopsOf1.Count - 1; i >= 0; i--)
            {
                var newVehicleStop = new VehicleStop(vehicles[2], stopsOf1[i], numberOfStop, stopsOf1.First().Name);
                vehicleStops.Add(newVehicleStop);
                TimeSpan tempTime = new TimeSpan(Time.Hours, Time.Minutes, 0);
                for (int j = 0; j < 36; j++)
                {
                    var newDepartureTime = new DepartureTime(tempTime, newVehicleStop);
                    departureTimes.Add(newDepartureTime);
                    tempTime += new TimeSpan(0, 30, 0);
                }
                numberOfStop++;
                Time += new TimeSpan(0, 2, 0);
            }
            //24 => Bronowice Małe
            Time = new TimeSpan(4, rand.Next(0, 50), 0);
            numberOfStop = 1;
            foreach (var stop in stopsOf24)
            {
                var newVehicleStop = new VehicleStop(vehicles[3], stop, numberOfStop, stopsOf24.Last().Name);
                vehicleStops.Add(newVehicleStop);
                TimeSpan tempTime = new TimeSpan(Time.Hours, Time.Minutes, 0);
                for (int j = 0; j < 36; j++)
                {
                    var newDepartureTime = new DepartureTime(tempTime, newVehicleStop);
                    departureTimes.Add(newDepartureTime);
                    tempTime += new TimeSpan(0, 30, 0);
                }
                numberOfStop++;
                Time += new TimeSpan(0, 2, 0);
            }
            //24 => Kurdwanów P+R
            Time = new TimeSpan(4, rand.Next(0, 50), 0);
            numberOfStop = 1;

            for (int i = stopsOf24.Count - 1; i >= 0; i--)
            {
                var newVehicleStop = new VehicleStop(vehicles[3], stopsOf24[i], numberOfStop, stopsOf24.First().Name);
                vehicleStops.Add(newVehicleStop);
                TimeSpan tempTime = new TimeSpan(Time.Hours, Time.Minutes, 0); 
                for (int j = 0; j < 36; j++)
                {
                    var newDepartureTime = new DepartureTime(tempTime, newVehicleStop);
                    departureTimes.Add(newDepartureTime);
                    tempTime += new TimeSpan(0, 30, 0);
                }
                numberOfStop++;
                Time += new TimeSpan(0, 2, 0);
            }

            List<Comment> comments = new()
            {
                new Comment("Great, only 5 min to Motorola", stopsOf52[0]),
                new Comment("Quiet place", stopsOf52[0]),
                new Comment("Great, only 7 min to Motorola", stopsOf52[1]),
                new Comment("To much students", stopsOf52[1]),
                new Comment("Actually It should named CampusUJ, cause it closer than 'Campus UJ stop'", stopsOf52[2]),
                new Comment("The bus stop is devastated. Probably because of some Sebiksa", stopsOf52[2]),
                new Comment("Close to Church, greetings, with god", stopsOf52[3]),
                new Comment("I hate this add about plastic segregation on stop ", stopsOf52[3]),
                new Comment("Students, students, students", stopsOf52[3]),
                new Comment("Criminals go there in order not to legally break into the bushes", stopsOf52[4]),
                new Comment("It's ok", stopsOf52[4]),
                new Comment("To much people there. Everytime", stopsOf52[5]),
                new Comment("Ticket Machine is fucked again", stopsOf52[5])
            };
            List<Route> routes = new()
            {
                new Route("Work - Home", vehicles[0], new TimeSpan(0, 22, 0))
            };
            List<RouteStop> routeStops = new()
            {
                new RouteStop(stopsOf52[0], routes[0], StopStatus.Starting),
                new RouteStop(stopsOf52[11], routes[0], StopStatus.Final)
            };
            List<Stop> stops = stopsOf52;
            foreach (var stop in stopsOf22)
            {
                if (stops.Where(s => s.Id == stop.Id).FirstOrDefault() != null) continue;
                else stops.Add(stop);
            }
            foreach (var stop in stopsOf1)
            {
                if (stops.Where(s => s.Id == stop.Id).FirstOrDefault() != null) continue;
                else stops.Add(stop);
            }
            foreach (var stop in stopsOf24)
            {
                if (stops.Where(s => s.Id == stop.Id).FirstOrDefault() != null) continue;
                else stops.Add(stop);
            }

            modelBuilder.Entity<Vehicle>()
                .HasData(vehicles);
            modelBuilder.Entity<Stop>()
                .HasData(stops);
            modelBuilder.Entity<Route>()
                .HasData(routes);
            modelBuilder.Entity<DepartureTime>()
                .HasData(departureTimes);
            modelBuilder.Entity<VehicleStop>()
                .HasData(vehicleStops);
            modelBuilder.Entity<RouteStop>()
                .HasData(routeStops);
            modelBuilder.Entity<Comment>()
                .HasData(comments);
        }
    }
}

