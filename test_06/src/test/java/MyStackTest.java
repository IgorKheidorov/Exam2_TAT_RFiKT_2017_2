import org.testng.annotations.Test;
import java.util.NoSuchElementException;
import static org.testng.Assert.*;

/**
 * This class is a test class for My Stack
 */
public class MyStackTest {

  @org.testng.annotations.Test
  public void testIsNotEmpty() throws Exception {
    MyStack stack = new MyStack();
    stack.push("Value");
    assertFalse(stack.isEmpty());
  }

  @org.testng.annotations.Test
  public void testIsEmpty() throws Exception {
    MyStack stack = new MyStack();
    assertTrue(stack.isEmpty());
  }

  @org.testng.annotations.Test
  public void testGetSize() throws Exception {
    MyStack stack = new MyStack();
    stack.push("Value");
    assertEquals(1, stack.getSize());
  }

  @org.testng.annotations.Test
  public void testGetSizeOfEmptyStack() throws Exception {
    MyStack stack = new MyStack();
    assertEquals(0, stack.getSize());
  }

  @org.testng.annotations.Test
  public void testPushToEmptyStack() throws Exception {
    MyStack stack = new MyStack();
    stack.push("Value");
    assertEquals("Value", stack.peek());
  }

  @org.testng.annotations.Test
  public void testPushToStackWithOneElement() throws Exception {
    MyStack stack = new MyStack();
    stack.push("Value");
    stack.push("New Value");
    assertEquals("New Value", stack.peek());
  }

  @org.testng.annotations.Test
  public void testPushToStackWithOneManyElements() throws Exception {
    MyStack stack = new MyStack();
    stack.push("Value");
    stack.push("New Value");
    stack.push("New Value");
    stack.push("Value Last");
    assertEquals("Value Last", stack.peek());
  }

  @org.testng.annotations.Test
  public void testClearFullStack() throws Exception {
    MyStack stack = new MyStack();
    stack.push("Value");
    stack.push("New Value");
    stack.push("New Value");
    stack.push("Value Last");
    stack.clear();
    assertEquals(0, stack.getSize());
  }

  @Test (expectedExceptions = NoSuchElementException.class)
  public void testClearEmptyStack() throws Exception {
    MyStack stack = new MyStack();
    stack.clear();
    throw new NoSuchElementException();
  }

  @org.testng.annotations.Test
  public void testPopReturnsDeletedValue() throws Exception {
    MyStack stack = new MyStack();
    stack.push("Value");
    stack.push("New Value");
    assertEquals("New Value", stack.pop());
  }
  @org.testng.annotations.Test
  public void testPopFunctionDuringDeliteReduceSize() throws Exception {
    MyStack stack = new MyStack();
    stack.push("Value");
    stack.push("New Value");
    stack.pop();
    assertEquals(1, stack.getSize());
  }

  @org.testng.annotations.Test
  public void testPeek() throws Exception {
    MyStack stack = new MyStack();
    stack.push("Value");
    stack.push("New Value");
    assertEquals("New Value", stack.peek());
  }

  @org.testng.annotations.Test
  public void testPeekDoNotDeletePeekedValue() throws Exception {
    MyStack stack = new MyStack();
    stack.push("Value");
    stack.push("New Value");
    assertEquals(2, stack.getSize());
  }

 @Test (expectedExceptions = NoSuchElementException.class)
  public void popFromEmptyStack() throws Exception {
    MyStack stack = new MyStack();
    stack.pop();
    throw new NoSuchElementException();
  }
}