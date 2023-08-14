using LinkedList;

namespace LinkedList.Tests;

[TestFixture]
public class LinkedListTests 
{
    private LinkedList<int> _list;

    [SetUp]
    public void Setup() 
    {
        _list = new();
    }
    
    [Test]
    public void AddElementToList_WhenElementAdded_ElementExistsInList() 
    {
        // ARRANGE
        bool elementExists = false;

        // ACT
        _list.AddElementToList(1);

        foreach (var element in _list) {
            if (element.Equals(1))
                elementExists = true;
        }

        // ASSERT
        Assert.That(elementExists, Is.True);
    }
}