public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[n, n];

        int num = 1;
        int x = 0, y = 0;
        int dx = 0, dy = 1; // 처음에는 오른쪽으로 이동

        bool[,] visited = new bool[n, n];

        for (int i = 0; i < n * n; i++) {
            answer[x, y] = num++;
            visited[x, y] = true;

            // 다음 위치 계산
            int nx = x + dx;
            int ny = y + dy;

            // 범위를 벗어나거나 이미 방문했다면 방향 전환
            if (nx < 0 || nx >= n || ny < 0 || ny >= n || visited[nx, ny]) {
                // 시계방향 방향 전환
                int temp = dx;
                dx = dy;
                dy = -temp;
            }

            x += dx;
            y += dy;
        }

        return answer;
    }
}
