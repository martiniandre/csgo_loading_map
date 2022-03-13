import styles from './loading.module.css'

export const LoadingBar = () => {
  return (
    <div className={styles.loadingBar}> 
      <strong>Loading...</strong>
      <div className={styles.progressContainer}>
        <div className={styles.progress}/>
      </div>
    </div>
  )
}