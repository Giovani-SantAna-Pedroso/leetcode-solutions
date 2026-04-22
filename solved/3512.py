class Solution:
    def minOperations(self, nums: List[int], k: int) -> int:
        return sum(nums) % k
        


sol = Solution()
print(sol.minOperations([3,9,7], 5))
print(sol.minOperations([4,1,3], 4))
print(sol.minOperations([3,2], 6))
