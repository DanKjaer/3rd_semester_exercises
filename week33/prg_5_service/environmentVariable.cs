using NUnit.Framework;

namespace gettingstarted.week33.prg_5_service;

[TestFixture]
public class environmentVariable
{
    [Test]
    public void TestPgConn()
    {
        // Arrange
        var result = Environment.GetEnvironmentVariable("pgconn");

        // Act

        // Assert
        Assert.AreEqual(result, "postgres://redzmisi:twQdOWnVBvb3I_l4-SnOeixD8UnM947K@snuffleupagus.db.elephantsql.com/redzmisi");
    }
}