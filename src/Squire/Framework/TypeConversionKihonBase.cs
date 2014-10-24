namespace Squire.Framework
{
    using NUnit.Framework;

    [TestFixture]
    public abstract class TypeConversionKihonBase : BaseKihon
    {
        [Test]
        public void Convert_String_To_Int()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(1, Convert_String_To_Int("1"));
        }

        protected abstract int Convert_String_To_Int(string data);

    }
}