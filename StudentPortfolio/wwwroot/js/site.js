(() => {
  const root = document.documentElement;
  const toggle = document.getElementById('themeToggle');
  const savedTheme = localStorage.getItem('theme') || 'light';
  root.setAttribute('data-theme', savedTheme);

  function updateIcon() {
    if (!toggle) return;
    toggle.innerHTML = root.getAttribute('data-theme') === 'dark'
      ? '<i class="bi bi-sun"></i>'
      : '<i class="bi bi-moon-stars"></i>';
  }
  updateIcon();

  toggle?.addEventListener('click', () => {
    const nextTheme = root.getAttribute('data-theme') === 'dark' ? 'light' : 'dark';
    root.setAttribute('data-theme', nextTheme);
    localStorage.setItem('theme', nextTheme);
    updateIcon();
  });

  const search = document.getElementById('projectSearch');
  const category = document.getElementById('categoryFilter');
  const cards = [...document.querySelectorAll('.project-card')];
  const noProjects = document.getElementById('noProjects');

  function filterProjects() {
    const query = (search?.value || '').toLowerCase().trim();
    const selected = category?.value || 'all';
    let visibleCount = 0;

    cards.forEach(card => {
      const matchesSearch = card.dataset.title?.includes(query) || card.dataset.tech?.includes(query);
      const matchesCategory = selected === 'all' || card.dataset.category === selected;
      const visible = matchesSearch && matchesCategory;
      card.classList.toggle('d-none', !visible);
      if (visible) visibleCount++;
    });

    noProjects?.classList.toggle('d-none', visibleCount !== 0);
  }

  search?.addEventListener('input', filterProjects);
  category?.addEventListener('change', filterProjects);
})();
