class Solution:
    def findDegrees(self, matrix: list[list[int]]) -> list[int]:
        return [ sum(i) for i in matrix]


solution = Solution()


print(solution.findDegrees([[0,1,1],[1,0,1],[1,1,0]]))
print(solution.findDegrees( [[0,1,0],[1,0,0],[0,0,0]]))
print(solution.findDegrees([[0]]))
        
