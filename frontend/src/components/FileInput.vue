<template>
  <section id="center">
    <!-- <div class="hero">
    </div> -->
    
    <div>
      <h1>EX-QL</h1>
      <p>Upload a <code>Excel (.xlsx)</code> file to begin</p>
    </div>

    <div class="mb-0">
      <input class="form-control" type="file" id="formFile" accept=".xlsx">
    </div>

    <div class="mb-0">
      <button type="button" class="btn btn-dark">
        Submit

      </button>
    </div>
  </section>

  <div class="ticks"></div>
  <div class="ticks"></div>

  <section id="spacer"></section>

  <footer class="mb-2">
    <div>
      developed by <strong>danny doan</strong>
    </div>
    <div class="social-logos">
      <a href="https://www.linkedin.com/in/dbdoan/" target="_blank" class="social-icon">
        <img :src="linkedinLogo" class="linkedin-logo" width="25" height="25">
      </a>
      <a href="https://github.com/dbdoan" target="_blank" class="social-icon">
        <img :src="githubLogo" class="github-logo ms-1" width="25" height="25">
      </a>
    </div>
  </footer>

</template>

<script setup lang="ts">
  // import { ref } from 'vue'
  import linkedinLogo from '../assets/linkedin_logo.svg';
  import githubLogo from '../assets/github_logo.svg';
</script>
