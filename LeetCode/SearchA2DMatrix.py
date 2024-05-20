    # Runtime 43 ms
    # Memory 17.20 MB

    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
      
        lines = len(matrix)
        cols = len(matrix[0])
        line = 0 
        col = cols - 1

        while line < lines and col >= 0:
            current = matrix[line][col]
            if current == target:
                return True
            if target > current:
                line += 1
            else:
                col -= 1
        return False
