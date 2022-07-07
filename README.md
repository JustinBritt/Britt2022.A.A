# Britt2022.A.A

C# implementation of the heuristics developed by [Britt et al. (2022)](https://www.doi.org/10.1504/IJOR.2022.121492)

## Modelling

| Component  | Project(s) |
| ------------- | ------------- |
| Constraints | Britt2022.A.A.Constraints |
| CrossJoins  | Britt2022.A.A.CrossJoinElements<br>Britt2022.A.A.CrossJoins |
| Indices  | Britt2022.A.A.IndexElements |
| Models | Britt2022.A.A.Models |
| Objective Functions | Britt2022.A.A.ObjectiveFunctions |
| Parameters | Britt2022.A.A.ParameterElements |
| Results | Britt2022.A.A.ResultElements<br>Britt2022.A.A.Results |
| Variables | Britt2022.A.A.VariableElements<br>Britt2022.A.A.Variables |

## Heuristics
Improvement heuristics are organized based on the level of embedding.

| Level of Embedding  | Project |
| ------------- | ------------- |
| N/A - Base Project | Britt2022.A.A.LocalSearches |
| None | Britt2022.A.A.StandaloneLocalSearches |
| Single | Britt2022.A.A.SingleEmbeddedLocalSearches |
| Double | Britt2022.A.A.DoubleEmbeddedLocalSearches |

| Heuristic | Level of Embedding | Project |
| -------------| ------------- | ------------- |
| Greedy Search | None | Britt2022.A.A.GS |
| Late Acceptance Hill Climbing | None | Britt2022.A.A.LAHC |
| Simulated Annealing | None | Britt2022.A.A.SA |
| Iterated Local Search | Single | Britt2022.A.A.ILS |
| Variable Neighbourhood Search | Single | Britt2022.A.A.VNS |
| Hybrid VNS-GA | Double | In Progress |