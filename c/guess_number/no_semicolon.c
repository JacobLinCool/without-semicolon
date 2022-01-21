#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void game(int answer, int input, int count) {
    while (
        printf("Guess a number: "),
        scanf("%d", &input),
        count++,
        input != answer ? (input > answer ? printf("Too high!\n") : printf("Too low!\n")) : 0
        ) {
    }

    if (printf("You win! You guessed %d times", count)) {}
}

int main() {
    if (srand(time(NULL)), game(rand() % 10 + 1, 0, 0), 0) {}
}
