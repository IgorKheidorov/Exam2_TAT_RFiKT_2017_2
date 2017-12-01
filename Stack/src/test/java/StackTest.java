import java.util.NoSuchElementException;

import static org.junit.Assert.*;

/**
 * Created by siarhey on 01.12.17.
 */
public class StackTest {
  @org.junit.Test
  public void checkIfCountsWhilePushingItem() throws Exception {
    Stack stack = new Stack();
    stack.push(1);
    assertEquals(1, stack.getNumberOfElements());
  }

  @org.junit.Test
  public void checkWhetherItemIsPushed() throws Exception {
    Stack stack = new Stack();
    stack.push(5);
    stack.push(6);
    assertEquals(6, stack.peek());
  }

  @org.junit.Test()
  public void checkIfGetsRightIndex() throws Exception {
    Stack stack = new Stack();
    stack.push(0);
    stack.push(1);
    stack.push(2);
    stack.push(3);
    stack.push(4);
    assertEquals(2, stack.search(2));
  }

  @org.junit.Test(expected = NoSuchElementException.class)
  public void checkIfThrowsExceptionIfStackIsEmptyWhilePopping() throws Exception {
    Stack stack = new Stack();
    stack.push(0);
    stack.push(1);
    stack.push(2);
    stack.pop();
    stack.pop();
    stack.pop();
    stack.pop();
  }

  @org.junit.Test()
  public void checkForNotFoundItem() throws Exception {
    Stack stack = new Stack();
    stack.push(0);
    stack.push(1);
    stack.push(2);
    assertEquals(-1, stack.search(5));
  }

  @org.junit.Test()
  public void checkIsEmptyAfterClear() throws Exception {
    Stack stack = new Stack();
    stack.push(0);
    stack.push(1);
    stack.push(2);
    stack.clear();
    assertEquals(-1, stack.peek());
  }
}