import org.junit.Test;
import java.util.NoSuchElementException;
import static org.junit.Assert.assertEquals;
public class MyStackTest {
  @Test
  public void isEmptyForEmptyStack() throws Exception {
  MyStack myStack = new MyStack();
  assertEquals(myStack.isEmpty(), true);
  }

  @Test
  public void isEmptyForNonEmptyStack() throws Exception {
    MyStack myStack = new MyStack();
    myStack.push("test");
    assertEquals(myStack.isEmpty(), false);
  }

  @Test
  public void getSizeForEmptyStack() throws Exception {
    MyStack myStack = new MyStack();
    assertEquals(myStack.getSize(), 0);
  }
  @Test
  public void getSizeForNonEmptyStack() throws Exception {
    MyStack myStack = new MyStack();
    myStack.push("test");
    myStack.push("test2");
    assertEquals(myStack.getSize(), 2);
  }
  @Test
  public void pushOneElementToEmptyStack() throws Exception {
    MyStack myStack = new MyStack();
    myStack.push("test");
    assertEquals(myStack.peek(), "test");
  }
  @Test
  public void pushOneElementToOneElementStack() throws Exception {
    MyStack myStack = new MyStack();
    myStack.push("test");
    myStack.push("test2");
    assertEquals(myStack.peek(), "test2");
  }

  @Test
  public void pushOneElementToSeveralElementsStack() throws Exception {
    MyStack myStack = new MyStack();
    myStack.push("test");
    myStack.push("test2");
    myStack.push("test3");
    assertEquals(myStack.peek(), "test3");
  }

  @Test(expected = NoSuchElementException.class)
  public void popFromEmptyStack() throws Exception {
    MyStack myStack = new MyStack();
    myStack.pop();
  }

  @Test
  public void popFromOneElementStack() throws Exception{
    MyStack myStack = new MyStack();
    myStack.push("test");
    assertEquals(myStack.pop(), "test");
  }

  @Test
  public void popFromSeveralElementsStack() throws Exception{
    MyStack myStack = new MyStack();
    myStack.push("test");
    myStack.push("test1");
    assertEquals(myStack.pop(), "test1");
  }

  @Test(expected = NoSuchElementException.class)
  public void peekFromEmptyStack() throws Exception {
    MyStack myStack = new MyStack();
    myStack.peek();
  }
  @Test
  public void peekFromOneElementStack() throws Exception {
    MyStack myStack = new MyStack();
    myStack.push("test");
    assertEquals(myStack.peek(), "test");
  }

  @Test
  public void peekFromSeveralElementsStack() throws Exception {
    MyStack myStack = new MyStack();
    myStack.push("test");
    myStack.push("test2");
    myStack.push("test3");
    assertEquals(myStack.peek(), "test3");
  }
  @Test
  public void clearForEmptyStack() {
    MyStack myStack = new MyStack();
    myStack.clear(myStack);
    assertEquals(myStack.getSize(), 0);
  }
  @Test
  public void clearForOneElementsStack() {
    MyStack myStack = new MyStack();
    myStack.push("test");
    myStack.clear(myStack);
    assertEquals(myStack.getSize(), 0);
  }
  @Test
  public void clearForSeveralElementsStack() {
    MyStack myStack = new MyStack();
    myStack.push("test");
    myStack.push("test1");
    myStack.clear(myStack);
    assertEquals(myStack.getSize(), 0);
  }
}