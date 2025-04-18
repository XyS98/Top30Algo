namespace Top30Algo.DataStructures;

// ListNode.cs
public class ListNode {
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null) {
        this.val = val;
        this.next = next;
    }

    // 静态方法构建链表（更高效）
    public static ListNode? FromArray(int[]? values) {
        if (values is null || values.Length == 0) return null;
        ListNode? head = new ListNode(values[0]);
        ListNode? current = head;
        for (int i = 1; i < values.Length; i++) {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    // 重写 ToString() 并优化显示
    public override string ToString() {
        var sb = new System.Text.StringBuilder();
        ListNode? current = this;
        while (current != null) {
            sb.Append(current.val);
            if (current.next != null) sb.Append(" -> ");
            current = current.next;
        }
        return sb.ToString();
    }
}