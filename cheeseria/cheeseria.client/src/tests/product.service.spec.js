import { CalculateCheesePrice } from "../services/product.service";
import { expect, test, describe } from "vitest";

describe("CalculateCheesePrice", () => {
  test("Multiply zero, return 0", () => {
    expect(CalculateCheesePrice(0, 0)).toBe(0);
  });

  test("Multiply both numbers together", () => {
    expect(CalculateCheesePrice(10, 5)).toBe(50);
  });

  test("Only one param, return 0", () => {
    expect(CalculateCheesePrice(10)).toBe(0);
  });

  test("No param, return 0", () => {
    expect(CalculateCheesePrice()).toBe(0);
  });
});