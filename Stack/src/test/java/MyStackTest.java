import java.util.EmptyStackException;

import static org.junit.Assert.*;

public class MyStackTest {

  @org.junit.Test
  public void pushItemInEmptyStackTest() {
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

  @org.junit.Test
  public void popItemInEmptyStackTest() {
    MyStack<String> myStack = new MyStack<String>();
    myStack.push("string one");
    assertEquals("string one", myStack.pop());
  }

  @org.junit.Test (expected = EmptyStackException.class)
  public void peek() {
    MyStack<String> myStack = new MyStack<String>();
    myStack.push("string one");
    myStack.push("string two");
    myStack.push("string three");
    assertEquals("string one", myStack.peek());
  }

  @org.junit.Test
  public void isEmpty() {
  }

  @org.junit.Test
  public void clear() {
  }
}