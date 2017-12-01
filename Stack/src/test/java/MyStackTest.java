import java.util.EmptyStackException;

import static org.junit.Assert.*;

public class MyStackTest {

  @org.junit.Test
  public void pushItemInEmptyStackTest() {
    //MyStack<String> myStack = new MyStack<String>();
    assertEquals("string", new MyStack<String>().push("string"));
  }

  @org.junit.Test
  public void pushItemNotEmptyStackTest() {
    MyStack<String> myStack = new MyStack<String>();
    myStack.push("string one");
    myStack.push("string two");
    myStack.push("string three");
    assertEquals(myStack.peek(), myStack.push("string test"));
  }

  @org.junit.Test (expected = EmptyStackException.class)
  public void popItemInEmptyStackTest() {
    MyStack<String> myStack = new MyStack<String>();
    myStack.push("string one");
    myStack.push("string two");
    assertEquals("string one", myStack.pop());
  }

  @org.junit.Test (expected = EmptyStackException.class)
  public void peek() {
  }

  @org.junit.Test
  public void isEmpty() {
  }

  @org.junit.Test
  public void clear() {
  }
}