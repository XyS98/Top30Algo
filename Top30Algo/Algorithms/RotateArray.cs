using Top30Algo.tools;

namespace Top30Algo;

/// <summary>
/// 2. 轮转数组 - 中等
/// [1,2,3,4,5]
/// [3,4,5,1,2] 
/// 1. 轮转 k = 3 (k>=0) 后变为 [3,4,5,1,2]
///     全部反转 == > [5,4,3,2,1]
///     轮转 前 3个 : 5,4,3 ==> [3,4,5,2,1]
///     轮转 后 2个 : 2,1 ==> [3,4,5,1,2]
/// </summary>
public class RotateArray
{
    public static void Rotate(int[] nums, int k)
    {
        if (nums.Length == 0 || k == 0) return;
        int length = nums.Length;
        k %= length;
        if (k == 0) return;

        //三次反转实现数组轮换
        ReverseArray(nums, 0, length - 1); // 反转所有元素
        ReverseArray(nums, 0, k - 1); // 反转前k个元素
        ReverseArray(nums, k, length - 1); // 反转剩余元素
    }

    //反转数组元素
    public static void ReverseArray(int[] nums, int start, int end)
    {
        int temp;
        while (start < end || start == end)
        {
            temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }

    public static void TestRotateArray()
    {
        // ================== 常规测试用例 ==================
        // 测试用例1: k < length 且 k <= length/2
        int[] array1 = { 1, 2, 3, 4, 5 };
        int k1 = 3;
        Console.WriteLine($"k1 = {k1} 原数组 array1: {CollectionFormatter.CollectionToString(array1)}");
        Rotate(array1, k1);
        Console.WriteLine($"轮转后: {CollectionFormatter.CollectionToString(array1)}");
        Console.WriteLine($"预期结果: [3, 4, 5, 1, 2]\n");

        // 测试用例2: k > length/2 (等效反向操作)
        int[] array2 = { 1, 2, 3, 4, 5, 6, 7 };
        int k2 = 5;
        Console.WriteLine($"k2 = {k2} 原数组 array2: {CollectionFormatter.CollectionToString(array2)}");
        Rotate(array2, k2);
        Console.WriteLine($"轮转后: {CollectionFormatter.CollectionToString(array2)}");
        Console.WriteLine($"预期结果: [3, 4, 5, 6, 7, 1, 2]\n");

        // ================== 边界条件测试 ==================
        // 测试用例3: k = 0
        int[] array3 = { 1, 2, 3 };
        int k3 = 0;
        Console.WriteLine($"k3 = {k3} 原数组 array3: {CollectionFormatter.CollectionToString(array3)}");
        Rotate(array3, k3);
        Console.WriteLine($"轮转后: {CollectionFormatter.CollectionToString(array3)}");
        Console.WriteLine($"预期结果: [1, 2, 3]\n");

        // 测试用例4: k = length (等效k=0)
        int[] array4 = { 1, 2, 3 };
        int k4 = 3;
        Console.WriteLine($"k4 = {k4} 原数组 array4: {CollectionFormatter.CollectionToString(array4)}");
        Rotate(array4, k4);
        Console.WriteLine($"轮转后: {CollectionFormatter.CollectionToString(array4)}");
        Console.WriteLine($"预期结果: [1, 2, 3]\n");

        // 测试用例5: 单元素数组
        int[] array5 = { 1 };
        int k5 = 100;
        Console.WriteLine($"k5 = {k5} 原数组 array5: {CollectionFormatter.CollectionToString(array5)}");
        Rotate(array5, k5);
        Console.WriteLine($"轮转后: {CollectionFormatter.CollectionToString(array5)}");
        Console.WriteLine($"预期结果: [1]\n");

        // 测试用例6: 空数组   
        int[] array6 = Array.Empty<int>();
        int k6 = 2;
        Console.WriteLine($"k6 = {k6} 原数组 array6: {CollectionFormatter.CollectionToString(array6)}");
        Rotate(array6, k6);
        Console.WriteLine($"轮转后: {CollectionFormatter.CollectionToString(array6)}");
        Console.WriteLine($"预期结果: []\n");

        // ================== 特殊内容测试 ==================
        // 测试用例7: 含负数元素
        int[] array7 = { -1, -100, 3, 99 };
        int k7 = 2;
        Console.WriteLine($"k7 = {k7} 原数组 array7: {CollectionFormatter.CollectionToString(array7)}");
        Rotate(array7, k7);
        Console.WriteLine($"轮转后: {CollectionFormatter.CollectionToString(array7)}");
        Console.WriteLine($"预期结果: [3, 99, -1, -100]\n");

        // 测试用例8: k > length (验证取模逻辑)
        int[] array8 = { 1, 2, 3 };
        int k8 = 7; // 等效k=1
        Console.WriteLine($"k8 = {k8} 原数组 array8: {CollectionFormatter.CollectionToString(array8)}");
        Rotate(array8, k8);
        Console.WriteLine($"轮转后: {CollectionFormatter.CollectionToString(array8)}");
        Console.WriteLine($"预期结果: [3, 1, 2]");
    }
}