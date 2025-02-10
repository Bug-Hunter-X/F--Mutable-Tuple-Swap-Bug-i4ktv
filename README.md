# F# Mutable Tuple Swap Bug

This repository demonstrates a subtle bug that can occur in F# when working with mutable variables and tuples. The bug arises from a misunderstanding of how mutable variables are handled when passed as part of a tuple.

## The Bug

The `bug.fs` file contains code that attempts to swap the values of two mutable variables using a tuple. However, due to the way mutable variables are handled in F#, the code produces unexpected results.

## The Solution

The `bugSolution.fs` file provides a corrected version of the code.  The solution avoids the mutable variables and tuples altogether and directly manipulates the variables.  It also includes comments to explain the change.  This version solves the problem, yielding the correct results.

## How to Reproduce

1. Clone this repository.
2. Open `bug.fs` and `bugSolution.fs` in your favorite F# editor.
3. Compile and run each file. Observe the different outputs.
