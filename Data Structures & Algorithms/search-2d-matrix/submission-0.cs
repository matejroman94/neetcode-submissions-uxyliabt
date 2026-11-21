public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var column = new MatrixColumn<int>(matrix, 0);
        var result = Search(column,target);
        return Search(matrix[result], target) != -1 ? true : false;
    }

    private int Search(MatrixColumn<int> column, int target)
    {
        int low = 0;
        int mid = 0;
        int high = 0;
        high = column.Count - 1;

        while (low <= high)
        {
            mid = low + (high - low) / 2;
            
            if (target == column[mid])
            {
                return mid;
            }
            else if (target > column[mid])
            {
                low = mid + 1;
                if (column.Count > low && 
                    target < column[low])
                {
                    return mid;
                }
            }
            else
            { 
                high = mid - 1;
                if (high > 0 &&
                    target > column[high])
                {
                    return mid;
                }
            }
        }
        
        return mid;
    }

    private int Search(int[] nums, int target)
    {
        int low, mid, high;
        low = 0;
        high = nums.Length - 1;

        while (low <= high)
        {
            mid = low + (high - low) / 2;
            
            if (target == nums[mid])
            {
                return mid;
            }
            else if (target > nums[mid])
            {
                low = mid + 1;
            }
            else
            { 
                high = mid - 1;
            }
        }

        return -1;
    }

    private readonly struct MatrixColumn<T>
    {
        private readonly T[][] matrix;
        private readonly int column;

        public MatrixColumn(T[][] matrix, int column)
        {
            this.matrix = matrix;
            this.column = column;
        }

        public int Count => matrix.Length;

        public T this[int index]
        {
            get => matrix[index][column];
            set => matrix[index][column] = value;
        }
    }
}
