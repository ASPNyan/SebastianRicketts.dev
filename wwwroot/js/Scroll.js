"use strict";

export function GetCurrentScrollYInPercent(element) {
    const scrollYInPx = element.scrollY;
    const elementHeightInPx = element.getBoundingClientRect().scrollHeight;
    return scrollYInPx / elementHeightInPx;
}