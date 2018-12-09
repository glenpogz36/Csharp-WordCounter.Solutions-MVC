using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountTheWords_NumberOfWords_Wordl()
    {
      //Arrange
      string input = "Basketball";
      string output = "I love Basketball";
      int count = 1;

      // Act
      int result = RepeatCounter.CountTheWords_Word(input, RepeatCounter.SplitTheText(output));

      //Assert
      Assert.AreEqual(count, result);
    }

    [TestMethod]
    public void Wordmatch_Exist_Word()
    {
      // Arrange
      string input = "eat";
      string output = "I love to cook and eat";
      int count = 1;

      // Act
      int result = RepeatCounter.CountTheWords(input, RepeatCounter.SplitTheText(output));

      // Assert
      Assert.AreEqual(count, result);
    }

    [TestMethod]
    public void Wordmatch_NotExist_Word()
    {
      // Arrange
      string input = "Eat";
      string output = "I love to cook and eat";
      int count = 0;

      // Act
      int result = RepeatCounter.CountTheWords(input, RepeatCounter.SplitTheText(output));

      // Assert
      Assert.AreEqual(count, result);
    }

    [TestMethod]
    public void wordToFind_IsNotExisting()
    {
      //Arrange
      string input = "sleep";
      string output = "This sample is a test";
      int count = 0;

      // Act
      int result = RepeatCounter.CountTheWords(input, RepeatCounter.SplitTheText(output));

      // Assert
      Assert.AreEqual(count, result);
    }
  }
}
