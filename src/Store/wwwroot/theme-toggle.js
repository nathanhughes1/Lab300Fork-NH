// Theme Toggle JavaScript
(function() {
    'use strict';

    const THEME_KEY = 'tinyshop-theme';
    const DARK_THEME = 'dark';
    const LIGHT_THEME = 'light';

    // Initialize theme on page load
    function initTheme() {
        // Add no-transition class to prevent flash during initial load
        document.documentElement.classList.add('no-transition');
        
        // Get saved theme or default to light
        const savedTheme = localStorage.getItem(THEME_KEY) || LIGHT_THEME;
        applyTheme(savedTheme);

        // Remove no-transition class after a brief delay
        requestAnimationFrame(() => {
            requestAnimationFrame(() => {
                document.documentElement.classList.remove('no-transition');
            });
        });
    }

    // Apply theme to document
    function applyTheme(theme) {
        if (theme === DARK_THEME) {
            document.documentElement.setAttribute('data-theme', DARK_THEME);
        } else {
            document.documentElement.removeAttribute('data-theme');
        }
    }

    // Toggle between themes
    window.toggleTheme = function() {
        const currentTheme = document.documentElement.getAttribute('data-theme');
        const newTheme = currentTheme === DARK_THEME ? LIGHT_THEME : DARK_THEME;
        
        applyTheme(newTheme);
        localStorage.setItem(THEME_KEY, newTheme);
    };

    // Get current theme (returns true if dark, false if light)
    window.getTheme = function() {
        const currentTheme = localStorage.getItem(THEME_KEY) || LIGHT_THEME;
        return currentTheme === DARK_THEME;
    };

    // Initialize on DOM content loaded
    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', initTheme);
    } else {
        initTheme();
    }

    // Also initialize immediately (for faster rendering)
    initTheme();
})();
