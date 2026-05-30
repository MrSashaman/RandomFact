document.addEventListener('DOMContentLoaded', () => {
    const btn = document.getElementById('toggle-btn');
    
    const themes = ['light', 'dark', 'forest', 'moon'];
    
    const savedTheme = localStorage.getItem('theme') || 'light';
    
    if (savedTheme !== 'light') {
        document.body.classList.add(`${savedTheme}-theme`);
    }

    btn.addEventListener('click', () => {
        let currentTheme = localStorage.getItem('theme') || 'light';
        
        let currentIndex = themes.indexOf(currentTheme);
        let nextIndex = (currentIndex + 1) % themes.length;
        let nextTheme = themes[nextIndex];

        if (currentTheme !== 'light') {
            document.body.classList.remove(`${currentTheme}-theme`);
        }

        if (nextTheme !== 'light') {
            document.body.classList.add(`${nextTheme}-theme`);
        }

        localStorage.setItem('theme', nextTheme);
    });
});
