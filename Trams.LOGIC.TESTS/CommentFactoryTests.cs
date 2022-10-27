namespace Trams.LOGIC.TESTS
{
    public class CommentFactoryTests
    {
        [Test]
        public void Create_ForNullArguments_ThrowsNullRefferenceException()
        {
            var commentFactory = new CommentFactory();
            Stop stop = null;
            string message = null;

            Action action = () => commentFactory.Create(message, stop);

            Assert.Throws<NullReferenceException>(() => action());
        }
        [Test]
        public void Create_ForCorrectArguments_ReturnsCorrectObject()
        {
            CommentFactory commentFactory = new();
            Stop stop = new("stop", "nice stop");
            string message = "message";

            var returnedComment = commentFactory.Create(message, stop);

            Assert.AreEqual(message, returnedComment.Message);
            Assert.AreEqual(stop.Id, returnedComment.StopId);
        }
    }
}
