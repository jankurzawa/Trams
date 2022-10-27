namespace Trams.LOGIC.TESTS
{
    public class RouteFactoryTests
    {
        [Test]
        public void Create_ForNullArguments_ReturnsNullReferenceException()
        {
            RouteFactory routeFactory = new();
            string name = null;
            Vehicle vehicle = null;
            TimeSpan timeSpan = new TimeSpan();

            Action action = () => routeFactory.Create(name, vehicle, timeSpan);

            Assert.Throws<NullReferenceException>(() => action());
        }
        [Test]
        public void Create_ForCorrectArguments_ReturnsNullReferenceException()
        {
            RouteFactory routeFactory = new();
            string name = "name";
            Vehicle vehicle = new(name, VehicleType.Tram);
            TimeSpan timeSpan = new TimeSpan(1,1,1);

            var returnedRoute = routeFactory.Create(name, vehicle, timeSpan);

            Assert.AreEqual(timeSpan, returnedRoute.Time);
            Assert.AreEqual(vehicle.Id, returnedRoute.VehicleId);
            Assert.AreEqual(name, returnedRoute.Name);
        }

    }
}
