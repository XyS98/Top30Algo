using Top30Algo.DataStructures;

namespace Top30Algo;

/// <summary>
/// 1. 反转单链表
/// 1-2-3-4-5 反转为 5-4-3-2-1
/// </summary>
public class ReverseSinglyLinkedList
{
// ReverseSinglyLinkedList.cs
    public static ListNode? ReverseList(ListNode? head)
    {
        ListNode? reversedNode = null;
        ListNode? current = head;
        ListNode? nextTemp = null;
        while (current != null)
        {
            nextTemp = current.next; // 保存 后续链表
            // 当前节点指向反转后的节点,构成新的反转链表
            current.next = reversedNode;
            reversedNode = current; // 保存最新的 反转链表
            current = nextTemp; // 准备处理 原链表中 下一个节点
        }

        return reversedNode;
    }

    public static void TestReverseSingleList()
    {
        // 正常链表
        var head1 = ListNode.FromArray(new[] { 1, 2, 3, 4, 5 });
        Console.WriteLine($"原链表: {head1}");
        var reversed1 = ReverseList(head1);
        Console.WriteLine($"反转后: {reversed1}\n");

        // 单节点链表
        var head2 = ListNode.FromArray(new[] { 1 });
        Console.WriteLine($"原链表: {head2}");
        var reversed2 = ReverseList(head2);
        Console.WriteLine($"反转后: {reversed2}\n");

        // 空链表
        ListNode? head3 = null;
        Console.WriteLine($"原链表: {head3}");
        var reversed3 = ReverseList(head3);
        Console.WriteLine($"反转后: {reversed3}");
    }
}