# Candy Distribution Analysis - LeetCode 2928

## 📝 Description
This project provides an optimized solution for distributing `n` identical candies among 3 distinct children, ensuring no child receives more than a specified `limit`.

## 🧠 The Mathematical Approach
Instead of using a naive brute-force approach ($O(n^2)$), this solution implements the **Inclusion-Exclusion Principle** combined with the **Stars and Bars** method.

### Key Logic (from the attached PDF):
1. [cite_start]**Total Distributions:** Calculated as $\binom{n+2}{2}$[cite: 21, 35].
2. [cite_start]**Handling Constraints:** We subtract cases where children exceed the limit ($x_i \ge L+1$)[cite: 17, 26].
3. [cite_start]**The Formula:** $$\binom{n+2}{2} - 3\binom{n-L+1}{2} + 3\binom{n-2L}{2} - \binom{n-3L-1}{2}$$ [cite: 35]

## 🚀 Optimization: From $O(n)$ to $O(1)$
The core strength of this implementation is its efficiency:
* [cite_start]**No Factorials:** To prevent **Integer Overflow** (which occurs at $n!$ for $n > 12$), I used the simplified combination identity: $\binom{n}{2} = \frac{n(n-1)}{2}$[cite: 43, 44].
* [cite_start]**Performance:** The solution runs in **Constant Time $O(1)$** and uses **$O(1)$ Space**[cite: 47].

## 📁 Files in this Repository
* `Solution.cs`: The optimized C# implementation.
* [cite_start]`LeetCode-2928Math.pdf`: Detailed handwritten mathematical derivation[cite: 1, 2].