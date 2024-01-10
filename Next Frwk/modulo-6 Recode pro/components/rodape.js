import React from 'react';
import styles from '@/styles/Footer.module.css';

const Footer = () => {
  return (
    <footer>
      <div className={styles.footerContainer}>
        <div className={styles.footerText}>
          <p>
            &copy; 2024 All Rights Reserved Viagens Recode
          </p>
        </div>
      </div>
    </footer>
  );
};

export default Footer;