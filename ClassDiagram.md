classDiagram
class Unit {
    + speed: float
    + health: float
    + TakeDamage(): void
}

class Elf {
    - Health: Int
    - ToggleVisibility(): void
}

class Brute {
    - Health: int
}

Unit <|-- Elf
Unit <|-- Brute
