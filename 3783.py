class Solution:
    def mirrorDistance(self, n: int) -> int:
        return abs (n - int( str(n)[::-1]))

s = Solution()

print(s.mirrorDistance(25))
print(s.mirrorDistance(10))
print(s.mirrorDistance(7))
